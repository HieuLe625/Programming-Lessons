using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class SV
    {
        public string hoten;
        public int namsinh;
        public string quequan;
        public SV()
        {

        }
        public void nhap()
        {
            Console.Write("Nhap vao ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap vao nam sinh: ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao que quan: ");
            quequan = Console.ReadLine();
        }
    }
    class SVDH : SV
    {
        public double diemtp;
        public double diemthi;
        public SVDH() : base()
        {

        }
        public void nhap1()
        {
            base.nhap();

            Console.Write("Nhap vao diem tp: ");
            diemtp = double.Parse(Console.ReadLine());
            Console.Write("Nhap voa diem thi: ");
            diemthi = double.Parse(Console.ReadLine());

            Console.WriteLine("");
        }
        public double diemtb()
        {
            return (diemthi * 0.7 + diemtp * 0.3);
        }
        public void In()
        {
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  | ", hoten, namsinh, quequan, diemtp, diemthi, diemtb());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            SVDH[] a = new SVDH[50];
            Console.Write("Nhap vao so sinh vien: ");
            n = int.Parse(Console.ReadLine());
            for(int i=0; i < n; i++)
            {
                a[i] = new SVDH();
                a[i].nhap1();
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|  Ho ten  |  Nam sinh  |  Que quan  |  diem tp  |  diem thi  |   diem tb  |");
            for (int i = 0; i < n; i++)
                a[i].In();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Danh sach moi");
            for (int i = 1; i < n; i++)
                a[i].In();

            Console.ReadLine();
        }
    }
}
