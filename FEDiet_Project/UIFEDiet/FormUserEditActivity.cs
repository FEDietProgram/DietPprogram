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
    public partial class FormUserEditActivity : Form
    {
        public FormUserEditActivity()
        {
            InitializeComponent();
        }
        User user;
        ActivityServices activityServices;
        public FormUserEditActivity(User _user)
        {
            InitializeComponent();
            activityServices = new ActivityServices();
            user = _user;   
        }

        private void FormUserEditActivity_Load(object sender, EventArgs e)
        {
            //user a ait olan aktiviteler
          List<Activity> activityList=  activityServices.ActivityList(dtpDate.Value, user);
                      
            foreach (Activity item in activityList)
            {
                ListViewItem list = new ListViewItem();
                list.Text = item.ActivityName;
                list.SubItems.Add(item.ActivityTime.ToString());
                list.SubItems.Add((item.BurnedCaloriePerHour * item.ActivityTime).ToString());
                list.Tag = item.ActivityID;
                lvActivity.Items.Add(list);
            }          
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Activity activity = cbActivity.SelectedItem as Activity;
                activityServices.ActivityAdd(user, activity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvActivity.SelectedItems.Count == 1)
                {
                    cbActivity.SelectedItem = lvActivity.SelectedItems[0].Text;
                    nudTime.Value = Convert.ToDecimal(lvActivity.SelectedItems[1].Text);

                    Activity activity = (Activity)activityServices.GetActivity((int)lvActivity.SelectedItems[0].Tag);

                    activity.ActivityName = cbActivity.SelectedItem.ToString();
                    activity.ActivityTime = nudTime.Value;

                    if (activityServices.ActivityUpdate(user,activity) >0)
                    {
                        MessageBox.Show("Aktivite güncellendi");
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
