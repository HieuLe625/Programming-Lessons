using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De1_cau1
{
    class CNVC
    {
        public string hoten;
        public double luong_cb;
        public double heso_luong;
        public CNVC() 
        { 

        }
        public void Nhap1()
        {
            Console.Write("Nhap vao ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao luong co ban: ");
            luong_cb = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao he so luong: ");
            heso_luong = double.Parse(Console.ReadLine());
        }
    }
    class CBPB : CNVC
    {
        public string donvi_congtac;
        public CBPB() : base() 
        {

        }
        public void Nhap2()
        {
            base.Nhap1();

            Console.Write("Nhap vao don vi cong tac: ");
            donvi_congtac = Console.ReadLine();

            Console.WriteLine("");
        }
        public double T()
        {
            return (luong_cb * heso_luong);
        }
        public void In()
        {
            Console.WriteLine("|   {0}   |   {1}   |   {2}   |   {3}   |    {4}    |", hoten, luong_cb, heso_luong, donvi_congtac, T());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            CBPB[] a = new CBPB[100];
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            if (n <= 2)
            {
                Console.WriteLine("Vui long nhap lai voi n > 2");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    a[i] = new CBPB();
                    a[i].Nhap2();
                }
                Console.WriteLine("|   Ho ten   |   Luong co ban   |   He so luong   |   Don vi cong tac   |   Tong luong   |");
                Console.WriteLine("Danh sach: ");
                for (int i = 0; i < n; i++)
                {
                    a[i].In();
                }
                Console.WriteLine("");
                Console.WriteLine("************************************************************");
                Console.WriteLine("Danh sach cac CBPB don vi cong tac PDT va co tong luong duoi 8 trieu");
                for (int i = 0; i < n; i++)
                {
                    if (a[i].donvi_congtac == "PDT" && a[i].T() < 8000000)
                        a[i].In();
                }

                Console.WriteLine("");
                Console.WriteLine("************************************************************");
                Console.WriteLine("Thay doi CBPB o vi tri 3 va 4");
                a[2] = new CBPB();
                a[2].Nhap2();
                a[3] = new CBPB();
                a[3].Nhap2();

                Console.WriteLine("Danh sach moi: ");
                for (int i = 0; i < n; i++)
                {
                    a[i].In();
                }
            }
            Console.ReadLine();
        }
    }
}
