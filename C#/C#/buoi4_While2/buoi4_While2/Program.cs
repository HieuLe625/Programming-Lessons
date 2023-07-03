using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4_While2
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;
            int i = 0;

            Console.Write("Nhap vao n: ");
            int n = System.Int16.Parse(Console.ReadLine());
            while (i < n)
            {
                T = T + i;
                i++;

            }
            Console.Write("Tong la : {0}", T);
            Console.ReadKey();

        }
    }
}
