using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinh_ke_thua
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string ten, int tuoi)
        {
            name = ten;
            age = tuoi;
        }
        public void Display()
        {
            Console.WriteLine("Ho ten: {0}", name);
            Console.WriteLine("Tuoi: {0}", age);
        }
    }
    public class Staff : Person
    {
        int workingYear;
        double salary;
        public Staff(string ten, int tuoi, int totalyear, double luong):base(ten, tuoi)
        {
            workingYear = totalyear;
            salary = luong;
         }
        public void show()
        {
            Display();
            Console.WriteLine("So nam cong tac: {0}", workingYear);
            Console.WriteLine("Luong: {0}", salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
