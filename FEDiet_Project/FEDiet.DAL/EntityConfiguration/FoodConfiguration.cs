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
    internal class FoodConfiguration:EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {

            Property(x => x.FoodName).IsRequired().HasMaxLength(50);

            Property(x => x.Neutrition).IsRequired();

            Property(x=>x.Calorie).IsRequired();

            //Navigations

            HasMany(x => x.Meals).WithMany(x => x.Foods);
        }
    }
}
