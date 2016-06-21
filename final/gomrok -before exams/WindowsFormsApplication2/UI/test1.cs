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
    public partial class test1 : Form
    {
        test1Ctrl tester = new test1Ctrl();
        public test1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            string test = (string)listBox1.SelectedItem;
            int r = tester.init_test(test);
            MessageBox.Show("match result: " + r);
        }

    }
}
