using FEDiet.BLL.Services;
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
    public partial class FormAdminReports : Form
    {
        AdminServices adminServices;
        public FormAdminReports()
        {
            InitializeComponent();
            adminServices = new AdminServices();
           
        }

        private void FormAdminReports_Load(object sender, EventArgs e)
        {
            cbReports.Items.Add("Kalorilerine Göre Kullanıcılar");
            cbReports.Items.Add("Tüketilme Sıklığına Göre Yiyecekler");
            cbReports.Items.Add("Öğünlere Göre Toplam Kalori");
            cbReports.Items.Add("Kilolarına Göre Kullanıcılar");       
            cbReports.Items.Add("Mesleklere Göre En Çok Tüketilen Yiyecekler");

        }

        private void cbReports_MouseClick(object sender, MouseEventArgs e)
        {
            switch (cbReports.SelectedIndex)
            {
                case 0: dgvReport.DataSource = adminServices.UserListbyCalorie(); break;
                case 1: dgvReport.DataSource = adminServices.UserMostConsumedFoods(); break;
                case 2: dgvReport.DataSource = adminServices.MealListbyCal(); break;
                case 3: dgvReport.DataSource = adminServices.UserListbyWeight(); break;
                case 4: dgvReport.DataSource = adminServices.MostConsumedFoodsAccordingToJobs(); break;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAdmin frm = new FormAdmin();
            this.Close();
            frm.Show();
            
        }
    }
}
