using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class UserServices
    {
        UserRepository userRepository;
        public UserServices()
        {
            userRepository = new UserRepository();  
        }

        public void AddUser(User _user)
        { 
            if (_user != null)
            {
                if (string.IsNullOrEmpty(userRepository.PasswordStrengthCheck(_user.Password)))
                {
                    userRepository.UserSignUp(_user);
                }
                else
                {
                    throw new Exception("Lütfen girdiğiniz parolayı kontrol ediniz.");
                }
                

            }
            else
            {
                throw new Exception("Kullanıcı bilgileri boş veya eksik!");
            }
            
        }
       
        public User CheckUser(string email,string password)
        {
            if (email == null && password == null)
            {
                throw new Exception("Mail adresinizi veya şifrenizi kontrol ediniz");             
            }
              return userRepository.CheckSignIn(email, password);
        }

        public decimal UserFatRate(DateTime day,User user)
        {
            decimal fatRate=0;
            if(user != null)
            {
               fatRate= userRepository.UserFatRate(day, user);
            }
            return fatRate;
        }

        public decimal UserCarbRate(DateTime day, User user)
        {
            decimal carbRate = 0;
            if (user != null)
            {
                carbRate = userRepository.UserFatRate(day, user);
            }
            return carbRate;
        }

        public decimal UserWaterRate(DateTime day, User user)
        {
            decimal waterRate = 0;
            if (user != null)
            {
                waterRate = userRepository.UserFatRate(day, user);
            }
            return waterRate;
        }

        public decimal UserProteinRate(DateTime day, User user)
        {
            decimal proteinRate = 0;
            if (user != null)
            {
                proteinRate = userRepository.UserFatRate(day, user);
            }
            return proteinRate;
        }

        public List<User> UserList()
        {
            return userRepository.UserList();
        }

        public int UserAge(DateTime date)
        {
            return userRepository.UserAge(date);
        }

        public string CheckPasswordStrength(string password)
        {
            return userRepository.PasswordStrengthCheck(password);
        }

    }
}
