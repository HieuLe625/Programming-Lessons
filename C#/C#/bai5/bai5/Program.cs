using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int year; 
            float tp, tk, thi;
            string hoten, Distric;
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
            for (byte i = 0; i < n; i++)
            {

                Console.Write("Ho va ten: ");
                hoten = Console.ReadLine();

                Console.Write("Nam Sinh: ");
                year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Que quan:");
                Distric = Console.ReadLine();

                Console.Write("Diem Thanh phan: ");
                tp = float.Parse(Console.ReadLine());

                Console.Write("Diem thi : ");
                thi = float.Parse(Console.ReadLine());

                Console.Write("Diem Tong ket: ");
                tk = float.Parse(Console.ReadLine());
               
                Console.WriteLine("-----------------------");
                // }
                // for (byte i = 0; i < n; i++)
                // {
                Console.WriteLine("Ho va ten: {0}", hoten);
                Console.WriteLine("Nam Sinh: {0}", year);
                Console.WriteLine("Que quan: {0}", Distric);
                Console.WriteLine("Diem thanh phan: {0}", tp);
                Console.WriteLine("Diem Thi: {0}", thi);
                Console.WriteLine("Diem tong ket: {0}", tk);
                Console.ReadKey();
                 }
                
          //  }
        }
    }
}
        
    