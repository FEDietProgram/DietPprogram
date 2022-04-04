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

            HasOptional(x => x.FoodCategory).WithMany(y => y.Foods).HasForeignKey(z => z.FoodCategoryID);
            HasMany(x => x.Meals).WithMany(y => y.Foods);
        }
    }
}
