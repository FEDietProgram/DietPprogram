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
                if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPassword2.Text))
                {
                    MessageBox.Show("Lütfen gerekli bilgileri giriniz.");
                    return;
                }
                int age = DateTime.Now.Year - dtDogumTarih.Value.Year;
                if (age >= 13)
                {
                    //if (chkTerms.Checked)
                    //{
                    if (state == false)
                    {

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
                        string gender="";
                        if (rbErkek.Checked) gender = "Male";
                        else if (rbKadin.Checked) gender = "Female";
                        userDetail.BodyFatRate =CalculateUserFatRate(numKilo.Value, numBoy.Value,gender,dtDogumTarih.Value);
                        userDetail.BodyMassIndex = CalculateUserBMI(numKilo.Value,numBoy.Value);

                        if (userDetailServices.AddUserDetail(userDetail))
                        {
                            MessageBox.Show("Kullanıcı bilgileri eklendi");
                        }
                    }

                    //  }
                    // else MessageBox.Show("Lütfen kullanıcı sözleşmesini okuduktan sonra onaylayınız");
                    else if (state == true)
                    {
                        user.Name = txtAd.Text;
                        user.Surname = txtSoyad.Text;
                        user.Email = txtEmail.Text;
                        user.UserDetail.Birthdate = dtDogumTarih.Value;
                        user.UserDetail.Job = txtMeslek.Text;
                        user.UserDetail.Height = (double)numBoy.Value;
                        user.UserDetail.Weight = (double)numKilo.Value;
                        user.UserDetail.NeckWidth = (double)nudNeck.Value;
                        user.UserDetail.WaistWidth = (double)nudWaist.Value;
                        user.UserDetail.HipWidth = (double)nudHip.Value;
                        user.UserDetail.UserDetailID = user.UserID;

                        if (userServices.UpdateUser(user)) MessageBox.Show("Kullanıcı güncellendi");
                        if (userDetailServices.UpdateUserDetail(user.UserDetail))
                        {
                            MessageBox.Show("Kullanıcı bilgileri güncellendi");
                        }
                    }
                }
                else MessageBox.Show("13 yaşından küçükler sisteme kayıt olamaz");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public double CalculateUserBMI(decimal mass, decimal height)
        {
            return Convert.ToDouble(mass / (height * height));
        }

        public double CalculateUserFatRate(decimal weight,decimal height,string gender,DateTime birth)
        {
            int age = DateTime.Now.Year - birth.Year;   
            if (gender == "Female")
            {
                if (age<13)
                {
                    return 1.20 * (double)CalculateUserBMI(weight,height) + 0.23 * age - 5.4;
                }
                else
                {
                    return 1.51 * (double)CalculateUserBMI(weight, height) + 0.70 * age + 1.4;
                }
            }
            else
            {
                if (age>13)
                {
                    return 1.20 * (double)CalculateUserBMI(weight, height) + 0.23 * age - 16.2;
                }
                else
                {
                    return 1.51 * (double)CalculateUserBMI(weight, height) + 0.70 * age - 2.2;
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswStrength.Text = PasswordStrength(txtPassword.Text);
        }


        public string PasswordStrength(string password)
        {
            string strength = "";
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Any(char.IsSymbol) && password.Length >= 6)
            {
                strength = "strong";
            }
            else if ((password.Any(char.IsUpper) || password.Any(char.IsLower) && !password.Any(char.IsSymbol)) && password.Any(char.IsDigit)  &&password.Length>4)
            {
                strength = "middle";
            }
            else if((password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Length<=4) || (password.All(char.IsDigit) || password.All(char.IsLetter)))
            {
                strength = "weak";
            }
            return strength;
        }

        private void btnBackClick_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
