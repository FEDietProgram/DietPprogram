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
           
            cbReports.Items.Add("Total Calory According To Meals");
            cbReports.Items.Add("Users According To User Weight");       

        }

        private void cbReports_MouseClick(object sender, MouseEventArgs e)
        {
            switch (cbReports.SelectedIndex)
            {
           
                case 0: dgvReport.DataSource = adminServices.MealListbyCal(); break;
                case 1: dgvReport.DataSource = adminServices.UserListbyWeight(); break;
                

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
