using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEDiet.BLL.Services
{
    public class WaterServices
    {
        WaterRepository waterRepository;
        public WaterServices()
        {
            waterRepository = new WaterRepository();    
        }

        //public int WaterAdd(User user,Water water, int cup)
        //{
        //    //if (water == null)
        //    //{
        //    //    throw new Exception("Eklenecek su adedi seçin");              
        //    //}
        //    //return waterRepository.UserWaterAdd(user, water, cup);
        //}

    }
}
