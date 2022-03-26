using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.EntityConfiguration
{
    public class SpecialStuationConfiguration:EntityTypeConfiguration<SpecialSituation>
    {
        public SpecialStuationConfiguration()
        {

            Property(x=>x.SituationName).IsRequired().HasMaxLength(50);
            Property(x => x.Neutrition).IsRequired();
            Property(x => x.DailyCalorieLimit).IsRequired();

        }
    }
}
