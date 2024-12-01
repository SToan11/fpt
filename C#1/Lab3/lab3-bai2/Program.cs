using System;

class Bai2_DanhSach_SinhVien
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        string[] hoTen = new string[n];
        double[] diem = new double[n];
        string[] hocLuc = new string[n];

        // Nhập thông tin sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cho sinh viên {i + 1}:");
            Console.Write("Họ tên: ");
            hoTen[i] = Console.ReadLine();

            Console.Write("Điểm: ");
            diem[i] = double.Parse(Console.ReadLine());

            // Xác định học lực
            if (diem[i] < 5)
                hocLuc[i] = "Yếu";
            else if (diem[i] < 6.5)
                hocLuc[i] = "Trung bình";
            else if (diem[i] < 7.5)
                hocLuc[i] = "Khá";
            else if (diem[i] < 9)
                hocLuc[i] = "Giỏi";
            else
                hocLuc[i] = "Xuất sắc";
        }
        // Sắp xếp theo điểm tăng dần
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (diem[i] > diem[j])
                {
                    // Hoán đổi thông tin sinh viên i và j
                    (hoTen[i], hoTen[j]) = (hoTen[j], hoTen[i]);
                    (diem[i], diem[j]) = (diem[j], diem[i]);
                    (hocLuc[i], hocLuc[j]) = (hocLuc[j], hocLuc[i]);
                }
            }
        }

        // Xuất thông tin sinh viên
        Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp:");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Họ tên\t\tĐiểm\t\tHọc lực");
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{hoTen[i]}\t\t{diem[i]}\t\t{hocLuc[i]}");
        }
        Console.WriteLine("--------------------------------------------------");
    }
}
