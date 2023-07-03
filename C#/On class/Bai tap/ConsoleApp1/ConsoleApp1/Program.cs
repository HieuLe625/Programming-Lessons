using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class sv
    {
        public string Hoten;
        public int namsinh;
        public string quequan;
        public sv() { }
        public void Nhapthongtin()
        {
            Console.Write("Nhap vao ho ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap vao nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao que quan: ");
            quequan = Console.ReadLine();
        }
     }
    class svdh : sv
    {
        int d1, d2, d3, d4, d5;

        public svdh() : base()
        {

        }
        public void Nhap()
        {
            base.Nhapthongtin();

            Console.Write("diem 1: ");
            d1 = int.Parse(Console.ReadLine());
            Console.Write("diem 2: ");
            d2 = int.Parse(Console.ReadLine());
            Console.Write("diem 3: ");
            d3 = int.Parse(Console.ReadLine());
            Console.Write("diem 4: ");
            d4 = int.Parse(Console.ReadLine());
            Console.Write("diem 5: ");
            d5 = int.Parse(Console.ReadLine());
        }
        public double dtb()
        {
            return ((d1 + d2 + d3 + d4 + d5) / 5);
        }
        public void hiemthi()
        {    
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} | {8}|", Hoten, namsinh, quequan, d1, d2, d3, d4, d5, dtb());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                svdh[] a = new svdh[100];
                Console.WriteLine("nhap vapo n: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    a[i] = new svdh();
                    a[i].Nhap();
                }

                Console.WriteLine("| Ho ten | Nam sinh | Que quan | d1 | d2 | d3 | d4 | d5 | dtb |");
                for (int i = 0; i < n; i++)
                    a[i].hiemthi();

                Console.WriteLine("************************************************************");

                Console.WriteLine("Danh sach cac sv o ND va DTB duoi 5 ");
                for (int i = 0; i < n; i++)
                {
                    if (a[i].quequan == "ND" && a[i].dtb() < 5)
                        a[i].hiemthi();
                }

                Console.ReadLine();
                    
                

            }
    }
}
