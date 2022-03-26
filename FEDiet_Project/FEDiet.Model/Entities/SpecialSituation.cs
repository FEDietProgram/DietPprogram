using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.Model.Entities
{
    public class SpecialSituation:BaseEntity
    {
        public int DailyCalorieLimit { get; set; }
        public Neutrition Neutrition { get; set; }
    }
}
