using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class tinhtoan
    {
        public int i, n, S, gt;
        public void Nhap(int i, int n)
        {
            for (i = 0; i < n; i++) { }
            Console.WriteLine("Nhap a[{0}]=", i);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int n, i, S = 0;

            Console.Write("Nhap vao so phan tu n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap {0} phan tu", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap a[{0}] = ", i);
                Console.WriteLine("a[{i}] = {1}", i,);
            }
            for (i = 0; i < n; i++)
            {
                S = S + a[i];
            }
            Console.WriteLine("Tong cac phan tu la: {0}", sum);
            Console.ReadLine();
        }
    }
}
