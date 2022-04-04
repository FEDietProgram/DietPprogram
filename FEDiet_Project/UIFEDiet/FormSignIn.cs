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
            userDetailServices = new UserDetailServices();
        }

        UserServices userServices;
        UserDetailServices userDetailServices;

        private void btnGiris_Click(object sender, EventArgs e)
        {


            try
            {
              
                    if (string.IsNullOrEmpty(txtMail.Text) || string.IsNullOrEmpty(txtSifre.Text))
                    {
                        MessageBox.Show("Mail ve şifre boş bırakılamaz");
                        return;
                    }
                    User user = userServices.CheckUser(txtMail.Text, txtSifre.Text);

                    if (user == null)
                    {
                        MessageBox.Show("Sistemde böyle bir kullanıcı kayıtlı değil. Kayıt sayfasına git!!");
                        return;
                    }

                    else
                    {
                        UserType userType = user.UserType;

                        switch (userType)
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
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 
        }
    }
}
