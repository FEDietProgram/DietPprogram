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
            HasKey(x=>x.UserID);
            //Property(x=>x.Name).IsRequired().HasMaxLength(50);
            //Property(x => x.Email).IsRequired().HasMaxLength(50);  
            //Property(x=>x.Surname).IsRequired().HasMaxLength(50);
            //Property(x => x.Password).IsRequired().HasMaxLength(50);
            //Navigations

            HasMany(x => x.Goals).WithMany(y => y.Users);
            HasMany(x => x.Meals).WithMany(y => y.Users);
            HasMany(x => x.Waters).WithMany(y => y.Users);
            HasMany(x => x.Activities).WithMany(y => y.Users);


        }
    }
}
