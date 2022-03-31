using FEDiet.BLL.Services;
using FEDiet.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFEDiet
{
    public partial class FormUserReports : Form
    {
        public FormUserReports()
        {
            InitializeComponent();
        }

        User user;
        UserServices userServices;
        public FormUserReports(User _user)
        {
            InitializeComponent();
            user = _user;
            userServices =  new UserServices();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormUser frm = new FormUser();
            this.Close();
            frm.ShowDialog();
        }

        private void FormUserReports_Load(object sender, EventArgs e)
        {
            lblBestDay.Text = userServices.BestDay(user).ToString();
            lblFailedDay.Text=userServices.UserFailedDay(user).ToString();
            lblFavFood.Text=userServices.FavoriteFoodbyUser(user);
           // lblFavMeal.Text=userServices.me yapacağım..
            lblMaxCalFood.Text=userServices.MaxCaloryOfUser(user);
            lblMaxCarbs.Text=userServices.MaxCarbsOfUser(user);
            lblMaxFat.Text=userServices.MaxFatOfUser(user);
            lblMaxPro.Text=userServices.MaxProteinOfUser(user);
            lblMaxWater.Text=userServices.MaxWaterOfUser(user);
            
        }

        private void rbDayly_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
