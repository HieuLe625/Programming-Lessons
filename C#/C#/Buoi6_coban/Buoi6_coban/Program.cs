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
        private int cao_h;
        public int mau;
        public hcn()
        {
            canh_a = 1;
            cao_h = 1;
        }
        public hcn(int a, int h)  // Bieu thuc
        {
            canh_a = a;
            cao_h = h;
        }
        
        public int chuvi() //phuong thuc
        {
            return 2 * (canh_a + cao_h);
        }
        public int dientich()
        {
            return canh_a * cao_h;
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
        }
    }
}
