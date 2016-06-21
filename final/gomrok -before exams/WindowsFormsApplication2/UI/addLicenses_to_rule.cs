using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.ctrller;
namespace WindowsFormsApplication2.UI
{
    public partial class addLicenses_to_rule : Form
    {
        ruleCtrl rc ;
        public addLicenses_to_rule()
        {
            InitializeComponent();

        }
        internal void setRuleCtrl(ruleCtrl _rc){
            rc = _rc;
        }

        private void addLicense_Click(object sender, EventArgs e)
        {
            string licenseName_ = licenseName.Text;
            string org_name = orgName.Text;
            MessageBox.Show("in add_license2_rule");
            MessageBox.Show("licenseName" + licenseName_);
            rc.add_to_licenseList(licenseName_, org_name);
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void orgName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
