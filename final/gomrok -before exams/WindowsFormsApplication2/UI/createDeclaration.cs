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
namespace gomrok
{
    public partial class createDeclaration : Form
    {
        decCtrl dc = new decCtrl();
        bizManCtrl bmc = new bizManCtrl();
        goodCtrl gc = new goodCtrl();
        public List<int> owned = new List<int>();


        private void updateGoodList()
        {
            List<string> items = gc.getGoodList();
            goodsList.DataSource = items;
        }
        public createDeclaration()
        {
            InitializeComponent();
        }

       
        private void addToGoodBtn_Click(object sender, EventArgs e)
        {
            addGood _addGood = new addGood();
            _addGood.gcSet(gc);
            DialogResult dr = _addGood.ShowDialog();
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

        private void addDeclareBtn_Click(object sender, EventArgs e)
        {

            string _bizManSsn = ssn.Text;
            string _bizManFirstname = firstName.Text;
            string _bizManLastname = lastName.Text;
            DateTime _date = dateTimePicker1.Value;
            int _transportType = comboBox1.SelectedIndex;
            string _originCountry = originCountry.Text;
            if (_bizManSsn.Length == 0 || _bizManFirstname.Length == 0 || _bizManLastname.Length == 0 || totalValue.Text.Length == 0 || _transportType == -1 || _originCountry.Length == 0)
                MessageBox.Show("لطفا همه ی فیلدها را پر کنید");
            else
            {
                int _totalVal = Convert.ToInt32(totalValue.Text);
                bmc.insert_new_bizMan(_bizManSsn, _bizManFirstname, _bizManLastname);
                dc.create_dec(_bizManSsn, _totalVal, _originCountry, _transportType);
                int decPK = dc.decID;
                gc.confirmGoodContainer(decPK);
                MessageBox.Show("اظهارنامه در سیستم ثبت شد");
            }
        }

        private void goodsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void show_license_Click(object sender, EventArgs e)
        {
            string _bizManSsn = null;
            string _bizManFirstname = null;
            string _bizManLastname = null;
            string _date = null;
            string _totalVal = null;
            int _transportType = -1; string _transType = null;
            string _originCountry = null;

            _bizManSsn = ssn.Text;
            _bizManFirstname = firstName.Text;
            _bizManLastname = lastName.Text;
            _date = "declarationDate.Text";

            _totalVal = totalValue.Text;
            _originCountry = originCountry.Text;
            _date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            _transportType = comboBox1.SelectedIndex;
            //هوایی
            //زمینی
            //دریایی
            if (totalValue.Text.Length == 0 || _transportType == -1 || _originCountry.Length == 0)
            {
                MessageBox.Show("لطفا همه ی فیلدها را پر کنید");
            }
            else
            {
                List<good> goodList = gc.getGoodlist_detail();
                int _totalVal_ = -1;
                if (!string.IsNullOrEmpty(_totalVal))
                    _totalVal_ = Convert.ToInt32(_totalVal);
                List<string> licenseNameList = dc.get_rule(_bizManSsn, _date, _totalVal_, _originCountry, _transportType, goodList);
                var message = string.Join(Environment.NewLine, licenseNameList);
                MessageBox.Show("لیست مجوز های لازم" + "\n" + message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void originCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            List<good> lg = new List<good>();
            lg = gc.get_container().goodList();
            int retval = dc.send_declare(owned, lg);
            if (retval == 1)
                MessageBox.Show("اظهارنامه تایید شد");
            else
                MessageBox.Show("اظهارنامه رد شد");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addToOwnedLicense_Click(object sender, EventArgs e)
        {
           string lic = null;
           lic = ownedLicense.Text;
           if(!String.IsNullOrEmpty(lic))
           {
               int licid = Convert.ToInt32(lic);
               owned.Add(licid);

           }
        }

        private void confirmOwnedLicense_Click(object sender, EventArgs e)
        {
            addToOwnedLicense.Enabled = false;
            MessageBox.Show("مجوز های موجود تایید شد");
        }

        


       
     
    }
}
