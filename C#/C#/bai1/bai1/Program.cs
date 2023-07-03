using System;
//using System.Collections Generic;
//using System.Linq;
//using System.Text;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap du lieu C# ");
            
            Console.Write("Nhap so nguyen thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Nhap du lieu thu 2: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Nhap so thuc: ");
            float c = float.Parse(Console.ReadLine());
            
            Console.Write("Nhap so chuoi: ");
            string d = Console.ReadLine();
            
            Console.WriteLine("|So nguyen1|SO nguyen2|So thuc|Chuoi|");
            Console.WriteLine("| {0} | {1} | {2}| {3} | ", a, b, c, d);
            Console.ReadKey();
        }
    }
}
