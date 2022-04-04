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
            //// ID -One to one USER
            Property(x => x.Height).IsRequired();
            Property(x => x.Weight).IsRequired();
            Property(x=>x.NeckWidth).IsRequired();
            Property(x=>x.WaistWidth).IsRequired();
            Property(x => x.HipWidth).IsRequired();
            Property(x => x.Job).HasMaxLength(30);
            Property(x => x.Gender).IsRequired().HasMaxLength(6);
            Property(x => x.Birthdate).IsRequired();
           

            // Navigations

            HasKey(x => x.UserDetailID);
            HasRequired(x => x.User).WithOptional(x => x.UserDetail);
           
           
        }
    }
}
