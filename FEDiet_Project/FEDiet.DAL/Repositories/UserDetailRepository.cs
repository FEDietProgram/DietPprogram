using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.DAL.Repositories
{
    public class UserDetailRepository
    {
        FEDietDbContext fEDietDbContext;
        public UserDetailRepository()
        {
            fEDietDbContext = new FEDietDbContext();    
        }


        public int UserAge(DateTime birth)
        {
            int age;
            age= DateTime.Now.Year- birth.Year;
            return age;
        }


        public AgeGroup UserAgeGroup(int age)
        {
            AgeGroup ageGroup;
            if (age > 0 && age <= 1) ageGroup = AgeGroup.infant;
            else if (age > 1 && age <= 8) ageGroup = AgeGroup.child;
            else if (age > 8 && age <= 18) ageGroup = AgeGroup.young;
            else if (age > 18 && age <= 50) ageGroup = AgeGroup.elder;
            else ageGroup = AgeGroup.old;
            return ageGroup;
        }

                    /*BKİ değerinin normal değerlerin (18.50-24.99
            kg/m2) altında ya da üzerinde olması sağlık
            riskinin arttığının göstergesidir.
               BKİ’nin hesaplanabilmesi için vücut ağırlığı
            ve boy uzunluğu tekniğine göre ölçülür. Vücut
            ağırlığının (kg cinsinden) boy uzunluğunun
            (metre cinsinden) karesine bölünmesiyle
            hesaplanır [BKİ: Vücut ağırlığı (kg) / boy
            uzunluğu (m)2].     
         */


        public decimal UserPerdayCalorie(UserDetail user)
        {
            decimal cal = 0;
            decimal index;


         
            if(user.AgeGroup==AgeGroup.infant)
            {
                if (user.Gender == true)
                {
                    //
                    cal = 111;
                }
                else { }
            }
            else if (user.AgeGroup== AgeGroup.child)
            {
                if(user.Gender == true)
                {
                    //
                    cal = 111;
                }
                else { }
            }

            else if (user.AgeGroup == AgeGroup.young)
            {
                if (user.Gender == true)
                {
                    //
                    cal = 111;
                }
                else { }
            }

            else if (user.AgeGroup == AgeGroup.elder)
            {
                if (user.Gender == true)
                {
                    //
                    cal = 111;
                }
                else { }
            }

            else if (user.AgeGroup == AgeGroup.old)
            {
                if (user.Gender == true)
                {
                    //
                    cal = 111;
                }
                else { }
            }

            return cal;

        }

                

    }
}
