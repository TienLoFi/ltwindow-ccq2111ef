using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
          Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

        string[] danhSachSinhVien = NhapSV(n);

        Console.WriteLine("\nDanh sach sinh vien:");
            XuatSV(danhSachSinhVien, n);

            Console.ReadKey();
        }
     
    static string[] NhapSV(int n)
    {
        string[] danhSachSinhVien = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ho ten sinh vien {0}: ", i + 1);
            danhSachSinhVien[i] = Console.ReadLine();
        }

        return danhSachSinhVien;
    }

    static void XuatSV(string[] danhSachSinhVien, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Sinh vien {0}: {1}", i + 1, danhSachSinhVien[i]);
        }

    }

}
}
