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
using gomrok.Entity;
namespace WindowsFormsApplication2.UI
{
    public partial class addLicense : Form
    {

        licensesCtrl lcstrl = new licensesCtrl();
        licenseDesCtrl lcdesctrl = new licenseDesCtrl();
        licenseMatsCtrl lcmctrl = new licenseMatsCtrl();
        public int counter = 1;
        public string user_org;
        public addLicense(licenseMatsCtrl _lmctrl,string org)
        {
            InitializeComponent();
            lcmctrl.init_licenseMatlist(_lmctrl.lmc);
            user_org = org;
        
        }
       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            lcstrl.add_all_licenses();
            lcmctrl.add_all_licenses();
            MessageBox.Show("مجوز(ها) با موفقیت ثبت شد");
                
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addNewLicense_Click(object sender, EventArgs e)
        {

            string bizSSN = null, name = null, strdate = null, enddate = null, srcCountry = null;
            bizSSN = textBox1.Text;
            name = textBox2.Text;
            int id = lcdesctrl.checkLicense(name);
            if (lcdesctrl.license_org != user_org)
            {
                MessageBox.Show("مجوز مربوطه متعلق به سازمان شما نمی باشد");
                return;
            }
            int transType = -1, minamount = -1, maxamount = -1;
            if(!String.IsNullOrEmpty(textBox3.Text))
                transType = Int32.Parse(textBox3.Text);
            if (!String.IsNullOrEmpty(textBox5.Text))
                minamount = Int32.Parse(textBox5.Text);
            if (!String.IsNullOrEmpty(textBox6.Text))
                maxamount = Int32.Parse(textBox6.Text);
          

            srcCountry = textBox4.Text;
            int lid = lcdesctrl.checkLicense(name);
            if (checkBox1.Checked == true)
            {
                strdate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            }
            if (checkBox2.Checked == true)
            {
                enddate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            }
            lcstrl.add_license(lid, bizSSN, name, transType, minamount, maxamount, strdate, enddate, srcCountry);
            counter += 1;

            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";

            //listbox1 مجوزها

            int count= 1;
            int last_id = lcstrl.get_last_id();
            string tt="last_id" +last_id.ToString();
            listBox1.Items.Clear();
            foreach (license lcc in lcstrl.lc.licenseList())
            {
                string lname = lcc.Name;
                string item = lname + "   " + (last_id+ count).ToString();
                listBox1.Items.Add(item);
                count += 1;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int lcid=lcstrl.get_last_id()+counter;
            addLicenseMat lm = new addLicenseMat(lcmctrl,lcid);
            lm.Data = new ctrldata();
            lm.Data.lmctrl = lcmctrl;
            DialogResult dr = lm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                lcmctrl = lm.Data.lmctrl;
            }

            listBox2.Items.Clear();
            foreach (licenseMat lcm in lcmctrl.lmc.licenseMatList())
            {
                string mname = lcm.MName;
                listBox2.Items.Add(mname);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*listBox2.Items.Clear();
            foreach(licenseMat lm in lcmctrl.lmc.licenseMatList()){
                string mname = lm.MName;
                listBox2.Items.Add(mname);
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = "";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            counter = 1;
            lcmctrl.lmc.clearList();
            lcstrl.lc.clearList();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                dateTimePicker1.Enabled = true;
            if (checkBox1.Checked == false)
                dateTimePicker1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                dateTimePicker2.Enabled = true;
            if (checkBox2.Checked == false)
                dateTimePicker2.Enabled = false;
        }


    }
}
