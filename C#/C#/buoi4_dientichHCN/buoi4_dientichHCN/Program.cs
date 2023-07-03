using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi4_dientichHCN
{
    class Program
    {
        static void Main(string[] args)
        {
            int cv, dt;
            int d, r;
            do
            {
                Console.Write("Nhap chieu dai: ");
                d = int.Parse(Console.ReadLine());
                Console.Write("Nhap chieu rong: ");
                r = int.Parse(Console.ReadLine());
            } while (d < 0 | r < 0);
                


            cv = 2 * (d + r);
            dt = d * r;
            Console.WriteLine("Chu vi la: {0}", cv);
            Console.WriteLine("Dien tich la: {0}", dt);
            Console.ReadKey();
        }   
        
    }
}
