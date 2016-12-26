using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car a1 = new Car("Lada", CategoryType.B);
                Car a2 = new Car("Lada", CategoryType.B);
                Car a3 = new Car("Lada", CategoryType.B);
                Car a4 = new Car("Gazel", CategoryType.C);
                List<Car> Cars = new List<Car> { a1, a2, a3, a4 };
                Instructor i1 = new Instructor("Вася", CategoryType.B);
                Instructor i2 = new Instructor("Саша", CategoryType.C);
                List<Instructor> Inst = new List<Instructor> { i1, i2 };
                Autoschool SFU = new Autoschool { Title = "SFU", Cars = Cars, Insts = Inst};
                a1.Instructor = i1;
                i1.Car = a1;
                a4.Instructor = i2;
                i2.Car = a4;
                Manager.SetVacation(i2);
                Manager.SetInstructor(a4, i1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
