using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = 0;
            int i = 0;
            Console.Write("Nhap vao n: ");
            int n = Convert.ToInt16(Console.ReadLine());
            do
            {
                T = T + i;
                i++;
            } while (i < n);
            Console.WriteLine("Tong la: {0}", T);
            Console.ReadKey();
        }
    }
}
