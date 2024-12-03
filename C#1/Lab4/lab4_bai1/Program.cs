using System;

class SanPham
{
    // Thuộc tính
    private string tenSp;
    private double donGia;
    private double giamGia;

    // Phương thức khởi tạo
    public SanPham(string tenSp, double donGia, double giamGia)
    {
        this.tenSp = tenSp;
        this.donGia = donGia;
        this.giamGia = giamGia;
    }

    // Phương thức tính thuế nhập khẩu
    public double GetThueNhapKhau()
    {   
        return 0.1 * donGia;
    }

    // Phương thức xuất thông tin ra màn hình
    public void Xuat()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Tên sản phẩm: " + tenSp);
        Console.WriteLine("Đơn giá: " + donGia);
        Console.WriteLine("Giảm giá: " + giamGia);
        Console.WriteLine("Thuế nhập khẩu: " + GetThueNhapKhau());
    }

    // Phương thức nhập thông tin từ người dùng
    public void Nhap()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập tên sản phẩm: ");
        tenSp = Console.ReadLine();

        Console.Write("Nhập đơn giá: ");
        while (!double.TryParse(Console.ReadLine(), out donGia) || donGia <= 0)
        {
            Console.WriteLine("Đơn giá phải là một số dương. Vui lòng nhập lại.");
            Console.Write("Nhập đơn giá: ");
        }

        Console.Write("Nhập giảm giá: ");
        while (!double.TryParse(Console.ReadLine(), out giamGia) || giamGia < 0 || giamGia >= donGia)
        {
            Console.WriteLine("Giảm giá phải là một số không âm và không vượt quá đơn giá. Vui lòng nhập lại.");
            Console.Write("Nhập giảm giá: ");
        }
    }
}

class Program
{
    static void Main()
    {
        // Tạo đối tượng SanPham
        SanPham sanPham = new SanPham("Sản phẩm 1", 100.0, 10.0);

        // Xuất thông tin
        sanPham.Xuat();

        // Nhập thông tin từ người dùng và xuất lại
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập thông tin mới:");
        sanPham.Nhap();
        sanPham.Xuat();
    }
}
