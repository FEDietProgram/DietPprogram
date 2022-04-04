using FEDiet.BLL.Services;
using FEDiet.DAL.Repositories;
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
            userServices = new UserServices();
            userDetailServices = new UserDetailServices();
            InitializeComponent();
            user = _user;
            state = true;
        }

        UserServices userServices;
        UserDetailServices userDetailServices;
        GoalServices goalServices;
        private void FormSignUp_Load(object sender, EventArgs e)
        {

           
            if (state == true)
            {
                txtAd.Text = user.Name;
                txtSoyad.Text = user.Surname;
                txtEmail.Text = user.Email;
                if(user.UserDetail.Gender=="Female") rbKadin.Checked = true;
                else rbErkek.Checked = true;
                dtDogumTarih.Value = user.UserDetail.Birthdate;
                numBoy.Value = (int)user.UserDetail.Height;
                numKilo.Value = (int)user.UserDetail.Weight;
                txtMeslek.Text = user.UserDetail.Job;
                nudNeck.Value = (int)user.UserDetail.NeckWidth;
                nudWaist.Value = (int)user.UserDetail.WaistWidth;
                nudHip.Value = (int)user.UserDetail.HipWidth;
                chkTerms.Visible = false;

                label11.Visible = txtPassword2.Visible=lblPasswStrength.Visible = false;
            }          

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {

                //if (chkTerms.Checked)
                //{
                if(state == false)
                {
                    if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPassword2.Text))
                    {
                        MessageBox.Show("Lütfen gerekli bilgileri giriniz.");
                        return;
                    }
                    if (!rbErkek.Checked || !rbKadin.Checked)
                    {
                        MessageBox.Show("Lütfen cinsiyetinizi giriniz.");
                    }

                    User user = new User();
                    user.Name = txtAd.Text;
                    user.Surname = txtSoyad.Text;

                    if (txtEmail.Text.EndsWith("@fediet.com"))
                    {
                        user.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Mail adresiniz fediet.com ile bitmeli");
                    }
                    user.UserType = UserType.StandardUser;

                    user.Password = txtPassword.Text;

                    if (txtPassword.Text == txtPassword2.Text && lblPasswStrength.Text != "weak")
                    {
                        if (userServices.AddUserAccount(user))
                        {
                            MessageBox.Show("Kullanıcı Eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı eklenemdi");
                        }

                    }
                    else MessageBox.Show("Girilen şifreler eşleşmiyor ya da zayıf");

                    UserDetail userDetail = new UserDetail();
                    userDetail.UserDetailID = user.UserID;

                    if (rbKadin.Checked)
                    {
                        userDetail.Gender = "Female";
                    }
                    else if (rbErkek.Checked)
                    {
                        userDetail.Gender = "Male";
                    }
                    userDetail.Job = txtMeslek.Text;
                    userDetail.Birthdate = dtDogumTarih.Value;
                    userDetail.Height = (double)numBoy.Value;
                    userDetail.Weight = (double)numKilo.Value;
                    userDetail.NeckWidth = (double)nudNeck.Value;
                    userDetail.WaistWidth = (double)nudWaist.Value;
                    userDetail.HipWidth = (double)nudHip.Value;
                    userDetail.BodyFatRate = userDetailServices.CalculateUserFatRate(userDetail);
                    userDetail.BodyMassIndex = userDetailServices.CalculateUserBMI(userDetail.Weight, userDetail.Height);

                    if (userDetailServices.AddUserDetail(userDetail))
                    {
                        MessageBox.Show("Kullanıcı bilgileri eklendi");
                    }
                }
                    
              //  }
               // else MessageBox.Show("Lütfen kullanıcı sözleşmesini okuduktan sonra onaylayınız");
                else  if (state == true)
                {
                    user.Name = txtAd.Text;
                    user.Surname = txtSoyad.Text;
                    user.Email = txtEmail.Text;
                    user.UserDetail.Birthdate = dtDogumTarih.Value;
                    user.UserDetail.Job = txtMeslek.Text;   
                    user.UserDetail.Height = (double)numBoy.Value;
                    user.UserDetail.Weight = (double)numKilo.Value;
                    user.UserDetail.NeckWidth = (double)nudNeck.Value;
                    user.UserDetail.WaistWidth= (double)nudWaist.Value;
                    user.UserDetail.HipWidth= (double)nudHip.Value;
                    user.UserDetail.UserDetailID = user.UserID;
             
                    if(userServices.UpdateUser(user)) MessageBox.Show("Kullanıcı güncellendi");
                    if (userDetailServices.UpdateUserDetail(user.UserDetail))
                    {
                        MessageBox.Show("Kullanıcı bilgileri güncellendi");
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);    
            }
            

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswStrength.Text = PasswordStrength(txtPassword.Text);
        }


        public string PasswordStrength(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Any(char.IsSymbol) && password.Length >= 6)
            {
                return "strong";
            }
            else if (password.Any(char.IsUpper) && password.Any(char.IsLower) || password.Any(char.IsDigit) && password.Length >= 4)
            {
                return "middle";
            }
            else
            {
                return "weak";
            }
        }
    }
}
