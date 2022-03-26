using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class UserDetail
    {
        public int ID { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Job { get; set; }
        public virtual User User { get; set; }

    }
}
