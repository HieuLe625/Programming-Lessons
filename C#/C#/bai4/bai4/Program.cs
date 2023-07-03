using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int T = 0;
                int i = 0;
                Console.Write("Nhap vao n: ");
                int n = int.Parse(Console.ReadLine());
            while (n < 1)
            {
                Console.WriteLine("Nhap lai");
                n = int.Parse(Console.ReadLine());
            }
                    for (i = 0; i < n; i++)
                    {
                        T = T + i;

                    }
                    Console.WriteLine("Tong la: {0}", T);
                    Console.ReadLine();             
        } 
    }
}
