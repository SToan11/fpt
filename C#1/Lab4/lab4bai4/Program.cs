using System;

class SanPham
{
    string tenSp;
    double donGia;
    double giamGia;

    // Getter và setter cho trường tenSp
    public string TenSp
    {
        get { return tenSp; }
        set { tenSp = value; }
    }

    // Getter và setter cho trường donGia
    public double DonGia
    {
        get { return donGia; }
        set { donGia = value; }
    }

    // Getter và setter cho trường giamGia
    public double GiamGia
    {
        get { return giamGia; }
        set { giamGia = value; }
    }

    // Hàm tạo thứ nhất
    public SanPham(string tenSp, double donGia, double giamGia)
    {
        TenSp = tenSp;
        DonGia = donGia;
        GiamGia = giamGia;
    }

    // Hàm tạo thứ hai (ngầm hiểu không giảm giá)
    public SanPham(string tenSp, double donGia) : this(tenSp, donGia, 0)
    {
    }

    // Phương thức tính thuế nhập khẩu (private)
    private double getThueNhapKhau()
    {
        return 0.1 * DonGia;
    }

    // Phương thức xuất thông tin ra màn hình (public)
    public void Xuat()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Tên sản phẩm: " + TenSp);
        Console.WriteLine("Đơn giá: " + DonGia);
        Console.WriteLine("Giảm giá: " + GiamGia);
        Console.WriteLine("Thuế nhập khẩu: " + getThueNhapKhau());
        Console.WriteLine();
    }

    // Phương thức nhập thông tin từ người dùng
    public void Nhap()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập tên sản phẩm: ");
        TenSp = Console.ReadLine();

        Console.Write("Nhập đơn giá: ");
        double.TryParse(Console.ReadLine(), out donGia);

        Console.Write("Nhập giảm giá: ");
        double.TryParse(Console.ReadLine(), out giamGia);
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Tạo 2 sản phẩm từ dữ liệu nhập từ bàn phím
        Console.WriteLine("Nhập thông tin cho sản phẩm 1:");
        SanPham sp1 = new SanPham("", 0, 0);
        sp1.Nhap();

        Console.WriteLine("Nhập thông tin cho sản phẩm 2:");
        SanPham sp2 = new SanPham("", 0, 0);
        sp2.Nhap();

        // Tạo 2 sản phẩm có sẵn
        SanPham sp3 = new SanPham("Sản phẩm 3", 200, 20);
        SanPham sp4 = new SanPham("Sản phẩm 4", 250);

        // Xuất thông tin của tất cả các sản phẩm
        Console.WriteLine("Thông tin sản phẩm 1:");
        sp1.Xuat();

        Console.WriteLine("Thông tin sản phẩm 2:");
        sp2.Xuat();

        Console.WriteLine("Thông tin sản phẩm 3:");
        sp3.Xuat();

        Console.WriteLine("Thông tin sản phẩm 4:");
        sp4.Xuat();
    }
}
