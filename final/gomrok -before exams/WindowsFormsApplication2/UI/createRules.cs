using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.Entity;
using gomrok.DB;
using gomrok.ctrller;

namespace WindowsFormsApplication2.UI
{
    
    public partial class createRules : Form
    {

        ruleCtrl rc = new ruleCtrl();
        ruleGoodCtrl gc = new ruleGoodCtrl();
        licenseDesCtrl lc = new licenseDesCtrl(); 

        private void updateGoodList()
        {
            List<string> items = gc.getGoodList();
            goodsList.DataSource = items;
        }

        private void updateLicenseList()
        {
            List<string> items = rc.get_licenseList();
            licenseList.DataSource = items;
        }
        public createRules()
        {
            InitializeComponent();
        }

        private void addToGoodBtn_Click(object sender, EventArgs e)
        {
            rule_good rg = new rule_good();
            rg.gcSet(gc);
            DialogResult dr = rg.ShowDialog();
        }

        private void addRuleBtn_Click(object sender, EventArgs e)
        {


            DateTime start_date = dateTimePicker_start.Value;
            DateTime finish_date = dateTimePicker_finish.Value;
            string min_total_val = null, max_total_val = null, _originCountry = null , _start_date = null, _finish_date = null;
            int _transportType = -1, int_min_total_val = -1, int_max_total_val = -1;
            min_total_val = rule_min_totalValue.Text;
            max_total_val = rule_max_totalValue.Text;
            _originCountry = originCountry.Text;
            if ( !String.IsNullOrEmpty(min_total_val)) 
                int_min_total_val = Convert.ToInt32(min_total_val);
            if (!String.IsNullOrEmpty(max_total_val))    
                int_max_total_val = Convert.ToInt32(max_total_val);

            _transportType = comboBox1.SelectedIndex;
            if (checkBox_startDate.Checked == true) {
                _start_date = start_date.ToString("yyyy-MM-dd");
            }
            if (checkBox_finishDate.Checked == true)
            {
                _finish_date = finish_date.ToString("yyyy-MM-dd");
            }
            {
                MessageBox.Show(min_total_val);
                rc.confirmLicenseList();
                rc.create_rule(ruleName.Text, int_min_total_val, int_max_total_val, _originCountry, _transportType, _start_date, _finish_date);
                int rulePK = rc.ruleID;
                gc.confirmGoodContainer(rulePK);
                MessageBox.Show("قانون در سیستم ثبت شد");
            }


        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            updateGoodList();
        }

        private void deleteGoodBtn_Click(object sender, EventArgs e)
        {
            string s = (string)goodsList.SelectedItem;
            gc.removeGood(s);
            updateGoodList();
        }

        private void createRules_Load(object sender, EventArgs e)
        {

        }

        private void addLicenseBtn_Click(object sender, EventArgs e)
        {
            addLicenses_to_rule l = new addLicenses_to_rule();
            l.setRuleCtrl(rc);
            DialogResult dr = l.ShowDialog();
        }

        private void checkBox_startDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_startDate.Checked == true)
                dateTimePicker_start.Enabled = true;
            if (checkBox_startDate.Checked == false)
                dateTimePicker_start.Enabled = false;
        }

        private void dateTimePicker_start_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_finish_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_finishDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_finishDate.Checked == true)
                dateTimePicker_finish.Enabled = true;
            if (checkBox_finishDate.Checked == false)
                dateTimePicker_finish.Enabled = false;
        }

        private void refresh_licenseBtn_Click(object sender, EventArgs e)
        {
            updateLicenseList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
