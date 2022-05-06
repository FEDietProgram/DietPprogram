using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    
    public class UserDetailServices
    {
        UserDetailRepository userDetailRepository;

        public UserDetailServices()
        {
            userDetailRepository = new UserDetailRepository();
        }


        public bool AddUserDetail(UserDetail userDetail)
        {
            if (userDetail == null)
            {
                throw new Exception("User Detail is null");
            }
            else
            {
                return userDetailRepository.AddUserDetail(userDetail);
            }
        }

        public bool UpdateUserDetail(UserDetail userDetail)
        {
            if (userDetail == null)
            {
                throw new Exception("User Detail is null");
            }
            else
            {
                return userDetailRepository.UpdateUserDetail(userDetail);
            }
        }

        public bool DeleteUserDetail(UserDetail userDetail)
        {
            if (userDetail == null)
            {
                throw new Exception("User Detail is null");
            }
            else
            {
                return userDetailRepository.DeleteUserDetail(userDetail);
            }
        }

        public int CalculatePregnancyWeek(UserDetail userDetail)
        {
            return userDetailRepository.CalculatePregnancyWeek(userDetail);
        }

        public UserDetail GetUserDetailByID(int id)
        {
            return userDetailRepository.GetUserDetailByID(id);
        }

        //public UserDetail FillUserDetailByUser(User user)
        //{
        //    return userDetailRepository.FillUserDetailByUser(user);
        //}

        //public bool UserGender(bool gender)
        //{
        //    bool genderResult = true;
        //    if (gender)
        //    {
        //        return genderResult;

        //    }
        //    else
        //    {
        //        genderResult = false;
        //        return genderResult;
        //    }
        //}

        //public int UserAge(DateTime birth)
        //{    
        //    int ageResult = 0;       
        //    if(birth!=null)
        //    {
        //      ageResult=  userDetailRepository.UserAge(birth);
        //    }

        //    else { throw new Exception("Doğum tarihinizi giriniz"); }

        //    return ageResult;   
        //}

        //public AgeGroup UserAgeGroups(int age)
        //{
        //    AgeGroup ageGroup = new AgeGroup();
        //    if (age !=0)
        //    {
        //        ageGroup = userDetailRepository.UserAgeGroup(age);
        //    }
        //    return ageGroup;
        //}


        public decimal UserPerdayCalorie(UserDetail user)
        {
            return userDetailRepository.UserPerdayCalorie(user);
        }

       
    }
}
