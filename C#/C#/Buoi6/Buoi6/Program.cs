using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6
{
    class tinhtoan
    {
        public static float binhphuong(float a)
        {
            return a * a;
        }
    }
    class hinhtron
    {
        float bankinh;
        public hinhtron(float gt)
        {
            bankinh = gt;
        }
        public float dientich()
        {
            return tinhtoan.binhphuong(bankinh);
        }

    }
    class hinhvuong
    {
        int b;
        int a, h;
        public hinhvuong()
        {
            b = 2;
        }
        public int chuvi()
        {
            return 2 * (a + h) ;
        }
        public int dientich()
        {
            return a * h;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            hinhtron h1 = new hinhtron(25);
            Console.WriteLine("Dien tich hinh tron: {0}", h1.dientich());
            Console.ReadKey();
        }
        
    }
}
