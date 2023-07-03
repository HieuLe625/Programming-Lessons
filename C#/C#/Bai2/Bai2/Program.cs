using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap du lieu C# ");

            Console.Write("Nhap so nguyen thu nhat: ");
            int a = int.Parse(Console.ReadLine()); // int.Parse chuyen doi thanh so nguyen tra ve gia tri a

            Console.Write("Nhap du lieu thu 2: ");
            int b = Convert.ToInt16(Console.ReadLine()); // Convert chuyen doi thanh cai do vd"Toint16"
            int bb = Convert.ToInt16("1231");

            Console.Write("Nhap so thuc: ");
            float c = float.Parse(Console.ReadLine());

            Console.Write("Nhap so chuoi: ");
            string d = Console.ReadLine();

            Console.WriteLine("|So nguyen1|SO nguyen2|So thuc|Chuoi|");
            Console.WriteLine(" {0}  {1}  {2} {3}  ", a,b,c,d);
            Console.WriteLine("So auto: {0}", a+3);
            Console.ReadKey();
        }
    }
}
