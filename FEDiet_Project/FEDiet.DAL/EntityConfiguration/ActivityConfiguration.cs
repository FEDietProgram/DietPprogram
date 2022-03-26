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
    internal class ActivityConfiguration:EntityTypeConfiguration<Activity>
    {
        public ActivityConfiguration()
        {
            HasKey(x=> x.ID);
            Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired().HasMaxLength(30);
            Property(x => x.ActivityTime).IsRequired();
            Property(x => x.BurnedCaloriePerHour).IsRequired();

        }
    }
}
