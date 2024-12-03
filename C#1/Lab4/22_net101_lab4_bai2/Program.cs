using System;

class SanPham
{
    // Trường dữ liệu của sản phẩm (private)
    private string tenSp;
    private double donGia;
    private double giamGia;
    // Hàm tạo thứ nhất
    public SanPham(string tenSp, double donGia, double giamGia)
    {
        this.tenSp = tenSp;
        this.donGia = donGia;
        this.giamGia = giamGia;
    }
    // Hàm tạo thứ hai (ngầm hiểu không giảm giá)
    public SanPham(string tenSp, double donGia)
        : this(tenSp, donGia, 0)
    {
    }
    // Getter và setter cho trường tenSp
    public string GetTenSp()
    {
        return this.tenSp;
    }
    public void SetTenSp(string tenSp)
    {
        this.tenSp = tenSp;
    }
    // Getter và setter cho trường donGia
    public double GetDonGia()
    {
        return this.donGia;
    }
    public void SetDonGia(double donGia)
    {
        this.donGia = donGia;
    }
    // Getter và setter cho trường giamGia
    public double GetGiamGia()
    {
        return this.giamGia;
    }
    public void SetGiamGia(double giamGia)
    {
        this.giamGia = giamGia;
    }
    // Phương thức xuất thông tin sản phẩm ra màn hình
    public void Xuat()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Tên sản phẩm: {GetTenSp()}");
        Console.WriteLine($"Đơn giá sản phẩm: {GetDonGia()}");
        Console.WriteLine($"Giảm giá sản phẩm: {GetGiamGia()}");
        Console.WriteLine($"Thành tiền: {GetThanhTien()}");
    }

    // Phương thức tính thành tiền 
    private double GetThanhTien()
    {
        return GetDonGia() - GetGiamGia();
    }
}
class Program
{
    static void Main()
    {
        // Sử dụng hàm tạo để tạo sản phẩm
        SanPham sp1 = new SanPham("Sản phẩm 1", 1000, 200);
        SanPham sp2 = new SanPham("Sản phẩm 2", 800);
        // Sử dụng getter và setter để đọc và ghi dữ liệu
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"Tên sản phẩm 1 trước khi thay đổi: {sp1.GetTenSp()}");
        sp1.SetTenSp("Sản phẩm mới 1");
        Console.WriteLine($"Tên sản phẩm 1 sau khi thay đổi: {sp1.GetTenSp()}");
        // Gọi phương thức xuất() để hiển thị thông tin sản phẩm ra màn hình
        Console.WriteLine("\nThông tin sản phẩm 1:");
        sp1.Xuat();
        Console.WriteLine("\nThông tin sản phẩm 2:");
        sp2.Xuat();
    }
}
