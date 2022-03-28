using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class SpecialSituation
    {
        public SpecialSituation()
        {
            Users = new HashSet<User>();
        }
         [Key]
        public int SituationID { get; set; }
        public string SituationName { get; set; }
        public int DailyCalorieLimit { get; set; }
        public Neutrition Neutrition { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
