using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int n, i, sum=0;

            Console.Write("Nhap vao so phan tu n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap {0} phan tu", n);
            for (i = 0; i < n; i++)
            { 
                a[i] = i + 1;
            }
            for (i=0; i < n; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("Tong cac phan tu la: {0}", sum);
            Console.ReadLine();
        }
    }
}
