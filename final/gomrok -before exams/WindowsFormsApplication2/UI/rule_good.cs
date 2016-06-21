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
    public partial class rule_good : Form
    {
        private ruleGoodCtrl gc = new ruleGoodCtrl();
        public rule_good()
        {
            InitializeComponent();
        }
        internal void gcSet(ruleGoodCtrl gct)
        {
            gc = gct;
        }


        private void rule_good_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addToGood_Click(object sender, EventArgs e)
        {
            string _goodName = null, _companyName = null;
            int min_weight = -1, max_weight = -1, min_qnty = -1, max_qnty = -1, min_uPrice = -1, max_uPrice = -1;
            _goodName = ruleGood_name.Text;

            if (!String.IsNullOrEmpty(ruleGood_min_weight.Text))
                min_weight = Convert.ToInt32(ruleGood_min_weight.Text);
            if (!String.IsNullOrEmpty(ruleGood_max_weight.Text))
                max_weight = Convert.ToInt32(ruleGood_max_weight.Text);

            if (!String.IsNullOrEmpty(ruleGood_min_qnty.Text))
                min_qnty = Convert.ToInt32(ruleGood_min_qnty.Text);
            if (!String.IsNullOrEmpty(ruleGood_max_qnty.Text))
                max_qnty = Convert.ToInt32(ruleGood_max_qnty.Text);

            if (!String.IsNullOrEmpty(ruleGood_min_unitPrice.Text))
                min_uPrice = Convert.ToInt32(ruleGood_min_unitPrice.Text);
            if (!String.IsNullOrEmpty(ruleGood_max_unitPrice.Text))
                max_uPrice = Convert.ToInt32(ruleGood_max_unitPrice.Text);

            _companyName = ruleGood_companyName.Text;
            {
                gc.add_good(_goodName, _companyName, min_weight, max_weight, min_qnty,max_qnty, min_uPrice, max_uPrice);
                MessageBox.Show("کالای جدید اضافه شد");
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

        private void ruleGood_min_unitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void ruleGood_max_unitPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
