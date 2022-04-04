using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class ActivityServices
    {
        UserRepository userRepository;
        ActivityRepository activityRepository;
        public ActivityServices()
        {
            userRepository = new UserRepository();
            activityRepository = new ActivityRepository();

        }

        //public int ActivityAdd(User user, Activity activity)
        //{
        //    if (activity == null)
        //    {
        //        throw new Exception("Aktivite bilgilerini girin");
        //    }

        //   return userRepository.AddActivityByUser(user, activity);
        //}

        //public int ActivityUpdate(User _user,Activity activity)
        //{
        //    if (activity == null)
        //    {
        //        throw new Exception("Güncellenecek aktivite seçiniz");
        //    }

        //    return userRepository.UpdateActivityByUser(_user, activity);
        //}

        //public List<Activity> ActivityList(DateTime date,User user)
        //{
        //    return userRepository.ActivityList(date,user); 
        //}

        //public Activity GetActivity(int id)
        //{
        //    if (id == 0)
        //    {
        //        throw new Exception("Activite seçilmedi");
        //    }
        //    return activityRepository.GetActivityByID(id);
        //}

        //public decimal BurnedCalory(User user, DateTime day)
        //{
        //   if(user == null)
        //    {
        //        throw new Exception("Kullanıcı bulunamadı");
        //    }

        //   return activityRepository.BurnedCalory(user, day);
        //}


    }
}
