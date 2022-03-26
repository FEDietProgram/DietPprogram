using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.EntityConfiguration
{
    internal class UserDetailConfiguration:EntityTypeConfiguration<UserDetail>
    {
        public UserDetailConfiguration()
        {
            // ID -One to one USER
            Property(x => x.Height).IsRequired();
            Property(x => x.Weight).IsRequired();
            Property(x => x.Gender).IsRequired();
            Property(x => x.BirthDate).IsRequired();

            // Navigations

            HasOptional(x => x.User).WithRequired(x => x.UserDetail);
           
           
        }
    }
}
