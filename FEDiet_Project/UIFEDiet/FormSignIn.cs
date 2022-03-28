using FEDiet.BLL.Services;
using FEDiet.Model.Entities;
using FEDiet.Model.Enums;
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
    public partial class FormSignIn : Form
    {       
        public FormSignIn()
        {
            InitializeComponent();
            userServices = new UserServices();
        }

        UserServices userServices;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                User user = userServices.CheckUser(txtMail.Text, txtSifre.Text);
                if (user != null) MessageBox.Show("Sistemde böyle bir kullanıcı kayıtlı değil. Kayıt sayfasına git!!"); return;

                switch (user.UserType)
                {
                    case UserType.StandardUser:
                        FormUser frmUser = new FormUser(user);
                        frmUser.ShowDialog();
                        break;
                    case UserType.Admin:
                        FormAdmin frmAdmin = new FormAdmin(user);
                        frmAdmin.ShowDialog();
                        break;
                }

                if (chkTerms.Checked == false) MessageBox.Show("Lütfen kullanıcı sözleşmesini okuduktan sonra onaylayınız");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 
        }
    }
}
