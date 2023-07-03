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
            hanghoa tivi = new hanghoa(25, "Tivi_Sony");
            hanghoa tulanh = new hanghoa();
            hanghoa maygiat = new hanghoa();
            hanghoa den = new hanghoa();
            tulanh.Dat_ten_hhhoa(" Tu lanh Samsung");
            tulanh.Dat_ma_hhhoa(5);
            den.Dat_ten_hhhoa(" den LED");

            tivi.so_luong = 2;
            tulanh.so_luong = 7;
            maygiat.so_luong = 10;
            den.so_luong = 4;
           
            Console.WriteLine(" Cac hang hoa co so luong < 5");
            tivi.In_tenhang_nhohon_A(5);
            tulanh.In_tenhang_nhohon_A(5);
            maygiat.In_tenhang_nhohon_A(5);
            den.In_tenhang_nhohon_A(5);



            Console.ReadLine();
        } 
    }
}
