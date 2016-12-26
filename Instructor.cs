using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Instructor
    {
        public string Name { get; set; }
        public CategoryType Category { get; set; }
        public Car Car { get; set; }
        public bool InWorked { get; set; }

        public Instructor(string Name, CategoryType Category)
        {
            this.Name = Name;
            this.Category = Category;
            this.InWorked = true;
        }
    }
}
