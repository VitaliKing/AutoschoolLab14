using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Autoschool
    {
        public string Title { get; set; }
        public List<Instructor> Insts { get; set; }
        public List<Car> Cars { get; set; }
    }
}
