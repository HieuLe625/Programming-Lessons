using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi6_coban
{
    class hcn
    {
        private int canh_a;
        private int rong_b;
        public int mau;
        public hcn()
        {
            canh_a = 1;
            rong_b = 1;
        }
        public hcn(int a, int b)
        {
            canh_a = a;
            rong_b = b;
        }

        public int chuvi() //phuong thuc
        {
            return 2 * (canh_a + rong_b);
        }
        public int dientich()
        {
            return canh_a * rong_b;
        }
        public int chuvi(int saiso) //phuong thuc
        {
            return 2 * (canh_a + rong_b) + saiso;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            hcn loainho;
            hcn loaito = new hcn(6, 3);
            hcn tdh60 = new hcn();
            tdh60.mau = 10;
            int chuviTdh60 = loaito.chuvi();
            int chuviTdhk60 = loaito.chuvi(2);
        }
    }
}
