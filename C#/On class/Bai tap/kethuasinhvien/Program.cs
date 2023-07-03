using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kethuasinhvien
{
    class sv
    {
        public string ht, qq;
        public int ns, msv;
        public sv()
        {

        }
        public void nhap()
        {
            Console.Write("Nhap ho ten sinh vien:");
            ht = Console.ReadLine();
            Console.Write("Nhap que quan sinh vien:");
            qq = Console.ReadLine();
            Console.Write("Nhap nam sinh cua sinh vien:");
            ns =int.Parse( Console.ReadLine());
            Console.Write("Nhap ma sinh vien:");
            msv = int.Parse(Console.ReadLine());
        }
    }
    class SVDH:sv
    {
        public float dt, dtp;
        public SVDH():base()
        {

        }
        public void nhap1()
        {
            base.nhap();
            Console.Write("Nhap diem thanh phan cua sinh vien:");
            dtp = float.Parse(Console.ReadLine());
            Console.Write("Nhap thi cua sinh vien:");
            dt = float.Parse(Console.ReadLine());
        }
        public double dtk()
        {
            return(Math.Round((0.7*dt+0.3*dtp),2));
        }
        public void hienthi()
        {
            Console.WriteLine("|  {0}   |    {1}   |   {2}   |    {3}   |  |  {4}   |    {5}   |  {6}  |", ht, qq, ns, msv, dt, dtp, dtk());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SVDH[] a = new SVDH[500];
            Console.Write("Nhap so luong sinh vien cua lơp SVDH: n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = new SVDH();
                a[i].nhap1();
            }
            Console.WriteLine("|  Ho ten   |   Que quan   |   Nam sinh   |    Ma sinh vien   |   Diem thi   |    Diem thanh phan   |  Diem tong ket  |");
            for (int i = 0; i < n; i++)
                a[i].hienthi();
            for (int i = 0; i < n; i++)
            { if (a[i].qq == "ND")
                    a[i].hienthi();
            }
            Console.ReadLine();
        }
    }
}
