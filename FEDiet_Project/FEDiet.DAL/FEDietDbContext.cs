using FEDiet.DAL.EntityConfiguration;
using FEDiet.DAL.Strategy;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL
{
    public class FEDietDbContext:DbContext
    {
        public FEDietDbContext() : base("Data Source=LAPTOP-CSE2LTTD\\SQLEXPRESS;Initial Catalog=FEDietDB;Integrated Security=true;")
        {
           Database.SetInitializer(new AdminStrategy());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities{ get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Water> Waters { get; set; }
        public DbSet<SpecialSituation> SpecialSituations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new ActivityConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new GoalConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new UserDetailConfiguration());
            modelBuilder.Configurations.Add(new SpecialStuationConfiguration());

        }


    }
}
