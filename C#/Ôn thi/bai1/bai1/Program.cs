using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class SV
    {
        public string hoten;
        public int namsinh;
        public string quequan;
        public SV() { }
        public void Nhap1()
        {
            Console.Write("Nhap vao Ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao que quan: ");
            quequan = Console.ReadLine();

        } 
    }
    class SVDH : SV
    {
        public double d1, d2, d3, d4, d5;
        public SVDH() : base()
        {

        }
        public void Nhap2()
        {
            base.Nhap1();

            Console.Write("Diem nam 1: ");
            d1 = double.Parse(Console.ReadLine());
            Console.Write("Diem nam 2: ");
            d2 = double.Parse(Console.ReadLine());
            Console.Write("Diem nam 3: ");
            d3 = double.Parse(Console.ReadLine());
            Console.Write("Diem nam 4: ");
            d4 = double.Parse(Console.ReadLine());
            Console.Write("Diem nam 5: ");
            d5 = double.Parse(Console.ReadLine());          
       }
        public double TB()
        {
            return ((d1 + d2 + d3 + d4 + d5) / 5);
        }
        public void In()
        {
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  |  {6}  |  {7}  |  {8}  |", hoten, namsinh, quequan, d1, d2, d3, d4, d5, TB());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            SVDH[] a = new SVDH[100];
            Console.Write("Nhap vao so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i <n; i++)
            {
                a[i] = new SVDH();
                a[i].Nhap2();
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("|  Ho ten  |  Nam sinh  |  Que quan  |  d1  |  d2  |  d3  |  d4  |  d5  |  TB  |");
            for (int i = 0; i < n; i++)
                a[i].In();

            Console.WriteLine("");
            Console.WriteLine("Danh sach que ND va DTB <5");

            for (int i = 0; i < n; i++)
            {
                if (a[i].quequan == "ND" && a[i].TB() < 5)
                {
                    a[i].In();
                }
            }
            Console.ReadLine();
        }
        
    }
}
