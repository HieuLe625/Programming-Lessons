using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethuasinhvien
{
    class HH
    {
        public string Ten_hh;
        public int Ma_hh;
        public string Ngaysx;
        public string Hansd;     
        public HH()
        {

        }
        public void nhapthongtin()
        {
            Console.Write("Nhap Ten hang hoa: ");
            Ten_hh = Console.ReadLine();
            Console.Write("Nhap Ma hang hoa: ");
            Ma_hh = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ngay san xuat: ");
            Ngaysx = Console.ReadLine();
            Console.Write("Nhap Han su dung: ");
            Hansd = Console.ReadLine();
        }
    }
    class Thucpham : HH
    {
        public int KL, Dongia;
        public string nhacungcap;
        public Thucpham() : base()
        {

        }
        public void nhapthucpham()
        {
            base.nhapthongtin();

            Console.Write("Nhap Khoi luong: ");
            KL = int.Parse(Console.ReadLine());
            Console.Write("Nhap Don gia': ");
            Dongia = int.Parse(Console.ReadLine());
            Console.Write("Nhap Nha cung cap: ");
            nhacungcap = Console.ReadLine();
        }
        //public double tinhtien()
        //{
        //    return (a[i].Dongia );
        //}
        public void hienthi()
        {
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}   |  {6}  |", Ten_hh, Ma_hh, Ngaysx, Hansd, KL, Dongia, nhacungcap);
              
        }

    }
    class Program
    {
         
        static void Main(string[] args)
        {
            double S = 0;
            Thucpham[] a = new Thucpham[100];
            Console.Write("Nhap so mat hang: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new Thucpham();
                a[i].nhapthucpham();
            }
            
            Console.WriteLine("|  Ten hang   |   Ma hang   |   Ngay sx   |   Han su dung  |   Khoi Luong   |    Don gia   |  Nha cung cap  |");
            // Cau b
            Console.WriteLine("Mat hang thu 3");   
            for (int i = 0; i < n; i++)
                a[2].hienthi();

            Console.WriteLine("****************************************************************************************************************************");
            // Cau c
            Console.WriteLine("Mat hang co Nha cung cap la Ba Vi va khoi luong duoi 5");
            for (int i = 0; i < n; i++)
            {
                if (a[i].nhacungcap == "Ba Vi" && a[i].KL < 5)
                    a[i].hienthi();
            }

            Console.WriteLine("****************************************************************************************************************************");
            for( int i= 0; i< n; i++)
            {
                S = S + a[i].Dongia;
                
            }
            Console.ReadLine();

        }
    }
}
