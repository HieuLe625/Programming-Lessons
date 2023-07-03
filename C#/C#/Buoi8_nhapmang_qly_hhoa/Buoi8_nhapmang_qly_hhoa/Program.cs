using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi7
{
    class hanghoa
    {
        private int Ma_hhoa;  // ko thay va ko dc sửa
        public string ten_hhoa;  // nhin` thay nhưng ko thể thay đổi
        protected int so_luong;
        public long don_gia;
        public hanghoa()
        {

        }
        public hanghoa(int ma, string ten) //, int soluong, long gia)
        {
            Ma_hhoa = ma;
            ten_hhoa = ten;
            // so_luong = soluong;
            // don_gia = gia;
        }
        public void So_luong(int sl)
        {
            so_luong = sl;
        }
        public void Dat_ten_hhhoa(string ten_hang)
        {
            ten_hhoa = ten_hang;
        }
        public void Dat_ma_hhhoa(int ma_hang)
        {
            Ma_hhoa = ma_hang;
        }
        public void In_tenhang()
        {
            Console.WriteLine("mat hang: {0}", ten_hhoa);
        }
        public void In_tenhang_nhohon_A(int a)
        {
            if (so_luong < a)
            {
                Console.WriteLine("mat hang: {0}", ten_hhoa);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int max = 50;    // so san pham
            int[] mang_so = new int[50];
            hanghoa[] List_hhoa = new hanghoa[max];


            // khoi tao phan tu cua cac doi tuong
            List_hhoa[0] = new hanghoa();
            List_hhoa[0].Dat_ten_hhhoa("Tivi Sony");
            List_hhoa[0].Dat_ma_hhhoa(3);
            List_hhoa[0].So_luong(5); 

            List_hhoa[1] = new hanghoa();
            List_hhoa[1].Dat_ten_hhhoa("Tu lanh LG");
            List_hhoa[1].Dat_ma_hhhoa(4);

            List_hhoa[2] = new hanghoa();
            List_hhoa[2].Dat_ten_hhhoa("May giat FAKE");
            List_hhoa[2].Dat_ma_hhhoa(5);

            for(int i=0; i < 4; i++)
            {
                //List_hhoa[i].In_tenhang();
                List_hhoa[i].In_tenhang_nhohon_A(5);
                Console.WriteLine("Co")
            }
            Console.ReadLine();




            //hanghoa tivi = new hanghoa(25, "Tivi_Sony");
            //hanghoa tulanh = new hanghoa();
            //hanghoa maygiat = new hanghoa();
            //hanghoa den = new hanghoa();
            //tulanh.Dat_ten_hhhoa(" Tu lanh Samsung");
            //tulanh.Dat_ma_hhhoa(5);
            //den.Dat_ten_hhhoa(" den LED");

            //tivi.so_luong = 2;
            //tulanh.so_luong = 7;
            //maygiat.so_luong = 10;
            //den.so_luong = 4;

            //Console.WriteLine(" Cac hang hoa co so luong < 5");
            //tivi.In_tenhang_nhohon_A(5);
            //tulanh.In_tenhang_nhohon_A(5);
            //maygiat.In_tenhang_nhohon_A(5);
            //den.In_tenhang_nhohon_A(5);



            Console.ReadLine();
        }
    }
}
