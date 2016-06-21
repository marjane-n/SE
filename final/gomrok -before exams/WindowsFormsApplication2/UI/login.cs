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
using gomrok.ctrller;
using gomrok.DB;
using gomrok.Entity;
using WindowsFormsApplication2.UI;

namespace gomrok
{
    public partial class login : Form
    {
        userCtrl uc = new userCtrl();
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            register srch = new register();
            DialogResult dr = srch.ShowDialog();
        }

      
        private void loginBtn_Click(object sender, EventArgs e)
        {
               
            string _username = userName.Text;
            string _password = password.Text;

            if(_username == "tester" && _password=="tester")
            {
                MessageBox.Show("خوش آمدید");
                this.Hide();
                test srch = new test();
                srch.Closed += (s, args) => this.Close();
                DialogResult dr = srch.ShowDialog();
            }
            int userType = uc.get_user_status(_username, _password);
            // -1: no entry
            //  1:کارشناس گمرک 
            //  2:نماینده سازمان
            // 3: وزارت اقتصاد
            // 3-> تصویب مجوز و قانون
            if (userType == -1)
            {
                MessageBox.Show("نام کاربری یا رمز عبور نادرست می باشد");
            }
           
            if (userType == 1)
            {
                MessageBox.Show("خوش آمدید");
                this.Hide();
                createDeclaration srch = new createDeclaration();
                srch.Closed += (s, args) => this.Close();
                DialogResult dr = srch.ShowDialog();
            }

            if (userType == 2)
            {
                MessageBox.Show("خوش آمدید");
                System.Threading.Thread.Sleep(1000);
                licenseMatsCtrl lmctrl= new licenseMatsCtrl();
                string org = uc.user_org;
                addLicense srch = new addLicense(lmctrl,org);
                DialogResult dr = srch.ShowDialog();
            }
            if (userType == 3)
            {
                createRules cr = new createRules();
                DialogResult dr = cr.ShowDialog();
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
