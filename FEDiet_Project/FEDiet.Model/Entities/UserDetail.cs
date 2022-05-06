using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class UserDetail
    {
        public int UserDetailID { get; set; }
        public virtual User User { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Job { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double NeckWidth { get; set; }
        public double WaistWidth { get; set; }
        public double HipWidth { get; set; }
        public string UserSituation { get; set; }
        public DateTime? PregnancyStartDate { get; set; }
        public List<string> AllergenicFoods { get; set; }
        public double DailyRequiredCaloryTaken { get; set; }
        public double DailyRequiredWaterConsumption { get; set; }
        public double BodyMassIndex { get; set; }
        public double BodyFatRate { get; set; }
        public AgeGroup AgeGroup { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public DietType DietType { get; set; }

    }
}
