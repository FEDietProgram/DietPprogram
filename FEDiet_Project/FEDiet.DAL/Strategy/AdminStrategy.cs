using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Strategy
{
    internal class AdminStrategy:CreateDatabaseIfNotExists<FEDietDbContext>
    {
        protected override void Seed(FEDietDbContext context)
        {
            User adminuser = new User()//userdetail ile optional olsun
            {
                Name = "Admin",
                Surname = "Admn",
                Email = "admin@gmail.com",
                Password = "1234",
                UserType=UserType.Admin
            };

            context.Users.Add(adminuser);   
            context.SaveChanges();  //tamam

    }
    }
}
