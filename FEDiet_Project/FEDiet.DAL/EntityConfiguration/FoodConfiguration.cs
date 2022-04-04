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
            Property(x => x.FoodName).IsRequired().HasMaxLength(30);
            Property(x => x.CaloryPerOnePortion).IsRequired();
            Property(x => x.ProteinCaloryPerGram).IsRequired();
            Property(x => x.FatCaloryPerGram).IsRequired();
            Property(x => x.CarbonhydratesCaloryPerGram).IsRequired();
      
            
            HasOptional(x => x.FoodCategory).WithMany(y => y.Foods).HasForeignKey(z => z.FoodCategoryID);
            HasMany(x => x.Meals).WithMany(y => y.Foods);
        }
    }
}
