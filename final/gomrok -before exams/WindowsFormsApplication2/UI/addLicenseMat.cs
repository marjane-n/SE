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
    public partial class addLicenseMat : Form
    {
        licenseMatsCtrl lmctrl = new licenseMatsCtrl();
        public int lid;
        
        public addLicenseMat(licenseMatsCtrl _lmctrl,int _lid)
        {
            InitializeComponent();
            lmctrl.init_licenseMatlist( _lmctrl.lmc);
            lid = _lid;
        }

        public ctrldata Data { get; set; }
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            int mminfee = -1,mmaxfee = -1,mminweight = -1,mmaxweight = -1,mmincount=-1,mmaxcount=-1;
            string mname =null,mcomp=null;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                mname = textBox1.Text;
            }
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                mcomp = textBox2.Text;
            }

            if (!String.IsNullOrEmpty(textBox3.Text))
            {
                mminfee = Int32.Parse(textBox3.Text);
            }

            if (!String.IsNullOrEmpty(textBox4.Text))
            {
                mmaxfee = Int32.Parse(textBox4.Text);
            }

            if (!String.IsNullOrEmpty(textBox5.Text))
            {
                mminweight = Int32.Parse(textBox5.Text);
            }

            if (!String.IsNullOrEmpty(textBox6.Text))
            {
                mmaxweight = Int32.Parse(textBox6.Text);
            }
            if (!String.IsNullOrEmpty(textBox7.Text))
            {
                mmincount = Int32.Parse(textBox7.Text);
            }
            if (!String.IsNullOrEmpty(textBox8.Text))
            {
                mmaxcount = Int32.Parse(textBox8.Text);
            }
            
            
            lmctrl.add_licenseMat(lid, mname, mcomp, mminfee, mmaxfee, mminweight, mmaxweight, mmincount, mmaxcount);
            this.Data.lmctrl = lmctrl;
        }

        private void button2_Click(object sender, EventArgs e)

        {
            string mm = Data.lmctrl.lmc.licenseMatList()[0].MName;
            MessageBox.Show(mm);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
