using FEDiet.BLL.Services;
using FEDiet.DAL.Repositories;
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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            userServices = new UserServices();
            userDetailServices = new UserDetailServices();
            state = false;
        }
        User user;
        bool state=false;
        public FormSignUp(User _user)
        {
            InitializeComponent();
            user = _user;
            state = true;
        }

        UserServices userServices;
        UserDetailServices userDetailServices;
        private void FormSignUp_Load(object sender, EventArgs e)
        {
            gbThrouhtAim.Visible = false;   
            if(state==true)
            {
                txtAd.Text = user.FirstName;
                txtSoyad.Text=user.LastName;
                txtEmail.Text = user.Email;
                user.UserDetail.Gender = true ? rbKadin.Checked : rbErkek.Checked;
                dtDogumTarih.Value = user.UserDetail.BirthDate;
                numBoy.Value = user.UserDetail.Height;
                numKilo.Value = user.UserDetail.Weight;
                txtMeslek.Text = user.UserDetail.Job;
                cbHedef.SelectedItem = user.Goal;
                numHedefKilo.Value = user.Goal.DesiredWeight;


            }
           
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.FirstName = txtAd.Text;
                user.LastName = txtSoyad.Text;
                user.Email = txtEmail.Text;
                user.Goal = (Goal)cbHedef.SelectedItem;
                user.Password = txtPassword.Text;
                bool genderOfUser = false;
                if (rbKadin.Checked)
                {
                    genderOfUser = true;
                }
                else if( rbErkek.Checked)
                {               
                    genderOfUser= false;
                }

                UserDetail userDetail = new UserDetail();
                userDetail.User = user;
                userDetailServices.UserGender(genderOfUser);
                                
                userDetail.BirthDate = dtDogumTarih.Value;
                userDetail.Job = txtMeslek.Text;
                userDetail.Height = numBoy.Value;
                userDetail.Weight = numKilo.Value;
                userDetail.AgeGroup = userDetailServices.UserAgeGroups(userDetailServices.UserAge(dtDogumTarih.Value));
                user.UserDetail.Gender = genderOfUser;
     
                if (txtPassword.Text == txtPassword2.Text)
                {
                    userServices.AddUser(user);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);    
            }
       

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswStrength.Text = userServices.CheckPasswordStrength(txtPassword.Text);
        }
    }
}
