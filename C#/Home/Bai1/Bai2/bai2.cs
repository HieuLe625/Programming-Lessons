using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class congnhan
    {
        public string hoten;
        public long luong_cb;
        public long he_so_luong;

        public congnhan() { }
        public void Nhapthongtin()
        {
            Console.Write("Nhap Ho ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap Luong co ban: ");
            luong_cb = long.Parse(Console.ReadLine());
            Console.Write("Nhap he so  luong: ");
            he_so_luong = long.Parse(Console.ReadLine());
        }
    }
    class Canbo : congnhan
    {
        public string donvicongtac;
        public Canbo() : base() 
        {

        }
        public void Nhap1()
        {
            base.Nhapthongtin();

            Console.Write("Nhap don vi cong tac: ");
            donvicongtac = Console.ReadLine();
        }
        public long Tongluong()
        {
            return (luong_cb * he_so_luong);
        }
         public void hiemthi1()
        {            
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  | ", hoten, luong_cb, he_so_luong, donvicongtac, Tongluong());
        }

    }
    class Giangvien : congnhan
    {
        public string subject;
        public int sonamcongtac;
        public Giangvien() : base() { }
        public void Nhap2()
        {
            base.Nhapthongtin();

            Console.Write("Bo nom quan ly': ");
            subject = Console.ReadLine();
            Console.Write("so nam cong tac: ");
            sonamcongtac = int.Parse(Console.ReadLine());
        }
        public long Tongthunhap()
        {
            return (luong_cb * (he_so_luong + sonamcongtac / 50));
        }
        public void hiemthi2()
        {          
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |  {3}  |  {4}  |  {5}  | ", hoten, luong_cb, he_so_luong, subject, sonamcongtac,Tongthunhap());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Canbo[] a = new Canbo[100];
            Giangvien[] b = new Giangvien[100];

            Console.Write("Nhap vao so can bo: ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i < n; i++)
            {
                a[i] = new Canbo();
                a[i].Nhap1();
            }

            Console.WriteLine("************************************************************************************************************");
            
            Console.Write("Nhap vao so Giang vien: ");
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                b[j] = new Giangvien();
                b[j].Nhap2();
            }
            Console.WriteLine("******************************************************************");
            Console.WriteLine("*                     HIEM THI DANH SACH                         *");
            Console.WriteLine("******************************************************************");
           
            Console.WriteLine("Can bo");
            Console.WriteLine("| Ho ten | luong cb | he so luong | Don vi cong tac | Tong luong | ");
            for (int i = 0; i < n; i++)
                a[i].hiemthi1();

            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("Giang vien");
            Console.WriteLine("| Ho ten | luong cb | he so luong | Bo nom | so nam cong tac | Tong luong | ");
            for (int j = 0; j < m; j++)
                b[j].hiemthi2();

            Console.ReadLine();
        }
       
    }

}
