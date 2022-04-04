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
            cbReports.Items.Add("Aktivite Sürelerine Göre Kullanıcılar");
            cbReports.Items.Add("Mesleklere Göre En Çok Tüketilen Yiyecekler");

        }

        private void cbReports_MouseClick(object sender, MouseEventArgs e)
        {
            switch (cbReports.Items.ToString())
            {
                case "Kalorilerine Göre Kullanıcılar": dgvReport.DataSource = adminServices.UserListbyCalorie(); break;
                case "Tüketilme Sıklığına Göre Yiyecekler": dgvReport.DataSource = adminServices.UserMostConsumedFoods(); break;
                case "Öğünlere Göre Toplam Kalori": dgvReport.DataSource = adminServices.MealListbyCal(); break;
                case "Kilolarına Göre Kullanıcılar": dgvReport.DataSource = adminServices.UserListbyWeight(); break;             
                case "Mesleklere Göre En Çok Tüketilen Yiyecekler":
                    adminServices.MostConsumedFoodsAccordingToJobs(); break;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //FormAdmin frm = new FormAdmin();
            //frm.Show();
            this.Close();
        }
    }
}
