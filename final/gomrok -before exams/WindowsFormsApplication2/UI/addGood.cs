using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using gomrok.ctrller;
namespace gomrok
{
    partial class addGood : Form
    {
        goodCtrl gc = new goodCtrl();
        public addGood()
        {
            InitializeComponent();
        }

        public void gcSet(goodCtrl gct)
        {
            gc = gct;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string _goodName = goodName.Text;
            string _companyName = companyName.Text;
            if (_goodName.Length == 0 || _companyName.Length == 0 || weight.Text.Length == 0 || quantity.Text.Length == 0 || price.Text.Length == 0)
                MessageBox.Show("لطفا همه ی فیلدها را پر کنید");
            else
            {
                int _weight = Convert.ToInt32(weight.Text);
                int _quantity = Convert.ToInt32(quantity.Text);
                int _price = Convert.ToInt32(price.Text);
                gc.add_good(_goodName, _companyName, _weight, _quantity, _price);
                MessageBox.Show("کالای جدید اضافه شد");
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
        }

    }
}
