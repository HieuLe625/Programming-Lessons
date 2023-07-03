using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class hinhtron
    {
        protected const double pi = 3.14;
        protected double r;
       
        public hinhtron(double bankinh)
        {
            r = bankinh;
        }
        //Định nghĩa một phương thức ảo của lớp hình tròn
        public virtual double dientich()
        {
            return (pi * r * r);
        }
    }
    
    class hinhtru : hinhtron 
    {
        public double h;
        public hinhtru(double bankinh, double chieucao) : base(bankinh)
        {
            h = chieucao;
        }    
        public override double dientich()
        {
            return (2 * pi * r * (h + r));
        }
    }
    class Program
    { 

        public static void Main(string[] args)
        {
            hinhtron h1 = new hinhtron(5.5);
            hinhtru h2 = new hinhtru(8.5, 10);
            Console.WriteLine("Dien tich cua hinh tron h1 là: {0}", h1.dientich());
            Console.WriteLine("Dien tich cua hinh tru h2 là: {0}", h2.dientich());
            Console.ReadLine();

        }
    }
}
