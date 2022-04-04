using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class Water
    {
        public Water()
        {
            Users = new HashSet<User>();
        }
        public int WaterID { get; set; }
        public double AmountOfWaterConsumed { get; set; }
        public DateTime WaterConsumedTime { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}
