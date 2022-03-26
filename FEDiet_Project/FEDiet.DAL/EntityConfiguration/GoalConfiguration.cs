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
    internal class GoalConfiguration : EntityTypeConfiguration<Goal>
    {
        public GoalConfiguration()
        {
            HasKey(x => x.GoalID);
           
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            //HasMany(x => x.Users).WithRequired(x => x.Goal).HasForeignKey(x => x.GoalID);

        }
    }
}
