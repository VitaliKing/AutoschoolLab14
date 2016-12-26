using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public string Title { get; set; }
        public CategoryType Category { get; set; }
        public Instructor Instructor { get; set; }

        public Car(string Title, CategoryType Category)
        {
            this.Title = Title;
            this.Category = Category;
        }
    }
}
