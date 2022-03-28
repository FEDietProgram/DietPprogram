using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FEDiet.DAL.Repositories;
using FEDiet.Model.Entities;

namespace UIFEDiet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        UserRepository userRespository;
        private void Form1_Load(object sender, EventArgs e)
        {

            userRespository = new UserRepository();
            User user = new User();
            userRespository.UserSignUp(user);
            
            

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FormSignUp form = new FormSignUp();
            form.ShowDialog();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            FormSignIn frmSginIn = new FormSignIn();
            frmSginIn.ShowDialog();
        }
    }
}
