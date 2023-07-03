using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 10;
            int T = 0;
            for ( i = 1; i <= n; i++)
            {
                Console.WriteLine("Nhap vao gia tri so n: ");
               // int n = int.Parse(Console.ReadLine());
                T = T + i;
                i++;
                Console.WriteLine("Gia tri cua T la: {0}", T);
                Console.ReadKey();
            }
        }
    }
}
