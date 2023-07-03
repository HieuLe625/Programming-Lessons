using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class HH
    {
        public string ten_hh;
        public int ma_hh;
        public string ngaysx;
        public string hangsd;
        public HH()
        {

        }
         public void Nhap()
        {
            Console.Write("Nhap Ten hang hoa: ");
            ten_hh = Console.ReadLine();
            Console.Write("Nhap Ma hang hoa: ");
            ma_hh = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ngay san xuat: ");
            ngaysx = Console.ReadLine();
            Console.Write("Nhap Han su dung: ");
            hangsd = Console.ReadLine();
        }
    }
    class Thucpham : HH
    {
        public double khoiluong;
        public double dongia;
        public string nha_cc;
        public Thucpham() : base()
        {

        }
        public void Nhap1()
        {
            base.Nhap();

            Console.Write("Nhap Khoi luong: ");
            khoiluong = double.Parse(Console.ReadLine());
            Console.Write("Nhap Don gia: ");
            dongia = double.Parse(Console.ReadLine());
            Console.Write("Nhap Nha cung cap: ");
            nha_cc = Console.ReadLine();
            Console.WriteLine("");
        }
        public void In()
        {
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |", ten_hh, ma_hh, ngaysx, hangsd, khoiluong, dongia, nha_cc);
        }
        public double Tongtien()
        {
            return (dongia);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Thucpham[] a = new Thucpham[100];
            Console.Write("Nhap vao so thuc pham: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new Thucpham();
                a[i].Nhap1();
            }
            Console.WriteLine("| Ten hh  |  Ma hh  |  Ngay sx  |  Han sd  |  Khoi luong  |  Don gia  |  Nha cung cap  |");
            for(int i = 0; i < n; i++)
            {
                a[i].In();
            }

            Console.WriteLine("-----------------");
            Console.Write("Mat hang thu 3");
            a[2].In();

            Console.WriteLine("-----------------");
            for(int i = 0; i < n; i++)
            {
                if(a[i].nha_cc =="Ba Vi" && a[i].khoiluong < 5)
                {
                    a[i].In();
                }
            }
            Console.ReadLine();
        
        }
    }
}
