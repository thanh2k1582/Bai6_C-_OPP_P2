using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QLHS quanLyHocSinh= new QLHS();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY KHACH SAN");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them hoc sinh.                                **");
                Console.WriteLine("**  2. Hien thi danh sach hoc sinh.                  **");
                Console.WriteLine("**  3. Hien thi danh sach hoc sinh 20 tuoi           **");
                Console.WriteLine("**  4. Hien thi danh sach hoc sinh 23 tuoi va o DN   **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        quanLyHocSinh.NhapHS();
                        Console.WriteLine("\nThem khach hang thanh cong!");
                        break;

                    case 2:
                        quanLyHocSinh.XuatHS(quanLyHocSinh.getListHocSinh());
                        break;
                    case 3:
                        quanLyHocSinh.XuatHS20T(quanLyHocSinh.getListHocSinh());
                        break;
                    case 4:
                        quanLyHocSinh.CountHS(quanLyHocSinh.getListHocSinh());
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}
