using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Manager
    {
        public static void SetVacation (Instructor Name)
        {
            Name.InWorked = false;
            Name.Car.Instructor = null;
            Name.Car = null;
        }
        public static void SetInstructor(Car Car, Instructor instructor)
        {
            if (Car.Category == instructor.Category)
            {
                Car.Instructor = instructor;
                instructor.Car = Car;
            }
            else
            {
                throw new Exception ("123");
            }
        }
    }
}
