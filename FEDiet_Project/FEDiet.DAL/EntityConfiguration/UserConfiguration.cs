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
    internal class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        { 
            HasKey(x=>x.ID);
            Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).IsRequired().HasMaxLength(30);
            Property(x => x.Email.EndsWith("@mail.com")).IsRequired();
            Property(x=>x.Password).IsRequired().HasMaxLength(15);

            //Navigations

            HasMany(x => x.Activities).WithMany(x => x.Users);
            HasMany(x => x.Foods).WithMany(x => x.Users);
            HasOptional(x=> x.Goal).WithMany(x => x.Users).HasForeignKey(x=>x.GoalID);
            HasMany(x => x.Meals).WithMany(x => x.Users);
            HasMany(x => x.Waters).WithMany(x => x.Users);

        }
    }
}
