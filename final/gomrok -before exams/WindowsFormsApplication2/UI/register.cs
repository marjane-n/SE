using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using gomrok.DB;
using gomrok.ctrller;
namespace gomrok
{
    public partial class register : Form
    {
        userCtrl uc = new userCtrl();
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
        }

      
       

        private void registerBtn__Click(object sender, EventArgs e)
        {
            string username = userName_.Text;
            string pass = password_.Text;
            string orgName = null;
            string _type = statusList.Text;
            int type = 4;
            int flag = 0;
            // -1: no entry
            //  1:کارشناس گمرک 
            //  2:نماینده سازمان
            // 3: وزارت اقتصاد
            if (username.Length == 0 || pass.Length == 0 || _type.Length == 0)
                MessageBox.Show("لطفا همه ی فیلدها را پر کنید");
            else
            {
                if (_type == "کارشناس گمرک")
                {
                    type = 1;
                }
                else if (_type == "نماینده سازمان")
                {
                    type = 2;
                    if (org.Text.Length == 0)
                        MessageBox.Show("لطفا همه ی فیلدها را پر کنید");
                    orgName = org.Text;
                }
                else if (_type == "نماینده وزارت اقتصاد")
                {
                    type = 3;
                }
                else
                {
                    type = 4;
                }
                uc.insert_new_user(username, pass, type, orgName);
                //uc.insert_new_user(username, pass, email);
                MessageBox.Show("کاربر جدید اضافه شد");
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void org_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void statusList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusList.Text == "نماینده سازمان")
            {
                org.Visible = true;
                orgName.Visible = true;
            }
            else
            {
                org.Visible = false;
                orgName.Visible = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

 

    
    }
}
