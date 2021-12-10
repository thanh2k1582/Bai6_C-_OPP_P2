using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class QLHS
    {
        private List<HocSinh> ListHocSinh = null;
        public QLHS()
        {
            ListHocSinh = new List<HocSinh>();
        }
        public void NhapHS()
        {
            HocSinh hs = new HocSinh();
            Console.Write("Nhap thong tin hoc sinh: \n");
            Console.Write("Nhap ten: ");
            hs.HoTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi: ");
            hs.Tuoi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap que quan: ");
            hs.QueQuan = Convert.ToString(Console.ReadLine());
            ListHocSinh.Add(hs);
        }
        public void XuatHS(List<HocSinh> listHS)
        {
            foreach (HocSinh hs in listHS)
            {
                Console.WriteLine("************************");
                Console.WriteLine("Thong tin hoc sinh");
                Console.WriteLine("Ten: {0}", hs.HoTen);
                Console.WriteLine("Tuoi: {0}", hs.Tuoi);
                Console.WriteLine("Que Quan: {0}", hs.QueQuan);
            }
            Console.WriteLine();
        }
        public void XuatHS20T(List<HocSinh> listHS)
        {
            int count = 0;
            foreach (HocSinh hs in listHS)
            {
                if (hs.Tuoi == 20)
                {
                    Console.WriteLine("************************");
                    Console.WriteLine("Thong tin hoc sinh");
                    Console.WriteLine("Ten: {0}", hs.HoTen);
                    Console.WriteLine("Tuoi: {0}", hs.Tuoi);
                    Console.WriteLine("Que Quan: {0}", hs.QueQuan);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Khong co hoc sinh nao 20 tuoi");
            }
            Console.WriteLine();
        }
        public void CountHS(List<HocSinh> listHS)
        {
            int count = 0;
            foreach (HocSinh hs in listHS)
            {
                if (hs.Tuoi == 23 && hs.QueQuan.ToUpper() == "DN")
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Khong co hoc sinh nao 23 tuoi va o DN");
            }
            else
            {
                Console.WriteLine("Co {0} hoc sinh 23 tuoi va o DN",count);
            }
            Console.WriteLine();
        }
        public List<HocSinh> getListHocSinh()
        {
            return ListHocSinh;
        }
    }
}
