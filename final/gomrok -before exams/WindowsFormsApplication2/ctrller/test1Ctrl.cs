using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.Entity;
using gomrok.DB;
using gomrok;

namespace gomrok.ctrller
{
    class test1Ctrl
    {
        ruleCtrl rc = new ruleCtrl();
        public int init_test(String testNum)
        {
            int result = -1;
            if(testNum == "test1")
            {
                result = test1run();
            }

            if (testNum == "test2")
            {
                result = test2run();
            }

            if (testNum == "test3")
            {
                result = test3run();
            }

            if (testNum == "test4")
            {
                result = test4run();
            }

            if (testNum == "test5")
            {
                result = test5run();
            }

            if (testNum == "test6")
            {
                result = test6run();
            }

            if (testNum == "test7")
            {
                result = test7run();
            }

            if (testNum == "test8")
            {
                result = test8run();
            }

            if (testNum == "test9")
            {
                result = test9run();
            }

            if (testNum == "test10")
            {
                result = test10run();
            }

            if (testNum == "test11")
            {
                result = test11run();
            }

            if (testNum == "test12")
            {
                result = test12run();
            }

            if (testNum == "test13")
            {
                result = test13run();
            }
            if (testNum == "test14")
            {
                result = test14run();
            }

            if (testNum == "test15")
            {
                result = test15run();
            }

            if (testNum == "test16")
            {
                result = test16run();
            }

            if (testNum == "test17")
            {
                result = test17run();
            }
            if (testNum == "test18")
            {
                result = test18run();
            }
            if (testNum == "test19")
            {
                result = test19run();
            }
            if (testNum == "test20")
            {
                result = test20run();
            }
            if (testNum == "test21")
            {
                result = test21run();
            }

            if (testNum == "test22")
            {
                result = test22run();
            }

            if (testNum == "test23")
            {
                result = test23run();
            }


            if (testNum == "test24")
            {
                result = test24run();
            }

            if (testNum == "test25")
            {
                result = test25run();
            }

            return result;
        }

        public int test1run()
        {
            good g = new good("shoe", "nike", 1, 1, 1);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            actualLicenseResult.Add("liccomp1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);

            MessageBox.Show("نتیجه تست1 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any())
                return 0;
            else
                return 1;
        }

        public int test2run()
        {
            good g = new good("shoe", "adidas", 1, 1, 1);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست2 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any())
                return 0;
            else
                return 1;
        }

        public int test3run()
        {
            good g = new good("computer", "asus", 1, 1, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست3 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any())
                return 0;
            else
                return 1;
        }

        public int test4run()
        {
            good g = new good("computer", "asus", 1, 200, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("liccount1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست4 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any())
                return 0;
            else
                return 1;
        }

        public int test5run()
        {
            good g = new good("pen", "uniball", 1, 40000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("liccount2");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست5 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count!= actualLicenseResult.Count )
                return 0;
            else
                return 1;
        }

        public int test6run()
        {
            good g = new good("headphone", "sony", 1, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("liccount3");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست6 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test7run()
        {
            good g = new good("rice", "mohsen", 6001, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست7 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test8run()
        {
            good g = new good("shampoo", "clear", 50, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست8 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test9run()
        {
            good g = new good("date", "mohsen", 1000, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("licweight3");
            actualLicenseResult.Add("licweight4");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست9 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test10run()
        {
            good g = new good("bag", "adidas", 800, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
          
            actualLicenseResult.Add("licweight5");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست10 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test11run()
        {
            good g = new good("flash", "transcend", 800, 1000, 300);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("licprice1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست11 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test12run()
        {
            good g = new good("adultcold", "abidi", 800, 1000, 1200);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست12 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test13run()
        {
            good g = new good("shirt", "adidas", 800, 1000, 700);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست13 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test14run()
        {
            good g = new good("chips", "mazzeh", 800, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();

            actualLicenseResult.Add("licprice4");
            actualLicenseResult.Add("licprice5");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست14 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test15run()
        {
            good g = new good("camary", "toyota", 800, 1000, 1000);
            good g1 = new good("azera", "hyundai", 1000, 1200, 2300);
            List<good> glist = new List<good>();
            glist.Add(g);
            glist.Add(g1);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("licname1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست15 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test16run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("lictrans1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "china", 2, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست16 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test17run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست17 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test18run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("licountry1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "sweden", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست18 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test19run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست19 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test20run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 2000, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست20 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }


        public int test21run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("lictotalval3");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 5000, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست21 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }
        public int test22run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 499, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست22 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test23run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 499, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست23 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test24run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval3");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 6000, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست24 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

        public int test25run()
        {
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval3");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            testResult = rc.get_rule_("2", DateTime.Now.ToString("yyyy-MM-dd"), 6000, "china", 1, glist);
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);
            MessageBox.Show("نتیجه تست25 " + msg + "\n" + "نتیجه ی مورد انتظار" + msg2);
            IEnumerable<string> diff = testResult.Except(actualLicenseResult);
            if (diff.Any() || testResult.Count != actualLicenseResult.Count)
                return 0;
            else
                return 1;
        }

    }
}
