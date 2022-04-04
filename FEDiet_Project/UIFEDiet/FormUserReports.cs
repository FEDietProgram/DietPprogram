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
            this.Close();           
        }

        private void FormUserReports_Load(object sender, EventArgs e)
        {
            lblBestDay.Text = userServices.BestDay(user).ToString();
            lblFailedDay.Text = userServices.UserFailedDay(user).ToString();
            lblFavFood.Text = userServices.FavoriteFoodbyUser(user);        
            lblMaxCalFood.Text = userServices.MaxCaloryOfUser(user);
            lblMaxCarbs.Text = userServices.MaxCarbsOfUser(user);
            lblMaxFat.Text = userServices.MaxFatOfUser(user);
            lblMaxPro.Text = userServices.MaxProteinOfUser(user);
        
        }

        private void rbDayly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDetailedReports_Click(object sender, EventArgs e)
        {
            FormUserDietDetails frm = new FormUserDietDetails(user);
            frm.ShowDialog();
        }
    }
}
