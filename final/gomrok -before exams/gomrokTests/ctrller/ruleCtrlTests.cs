using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gomrok.ctrller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gomrok.Entity;
using gomrok;
using WindowsFormsApplication2.Entity;

namespace gomrok.ctrller.Tests
{
    [TestClass()]
    public class ruleCtrlTests
    {
      
        ruleCtrl rc = new ruleCtrl();
        List<rule> l_rule = new List<rule>();
        List<license_rule_entity> l_rule_licenseName = new List<license_rule_entity>();
       // rule(int _ruleID, string _rulename, int _min_totalVal, int _max_totalVal, string _originCountry, int _transType, string _start_date, string _finish_date)
        public void setRule(){

            l_rule.Add(new rule(33, "ruleTrans1", -1, -1, "", 2, "", ""));
            l_rule_licenseName.Add(new license_rule_entity("lictrans1", "", 1, 3));

            l_rule.Add(new rule(34, "ruleCountry1", -1, -1, "sweden",-1, "", ""));
            l_rule_licenseName.Add(new license_rule_entity("licountry1", "", 1, 3));

            l_rule.Add(new rule(35, "ruleTotalVal1", 500, 3500, "", -1, "", ""));
            l_rule_licenseName.Add(new license_rule_entity("lictotalval1", "", 1, 3));

            l_rule.Add(new rule(36, "ruleTotalVal2", -1, 5000, "", -1, "", ""));
            l_rule_licenseName.Add(new license_rule_entity("lictotalval2", "", 1, 3));

            l_rule.Add(new rule(37, "ruleTotalVal3", 5000, -1, "", -1, "", ""));
            l_rule_licenseName.Add(new license_rule_entity("lictotalval3", "", 1, 3));

            l_rule.Add(new rule(38, "ruledate1", -1, -1, "", -1, "2000-04-01", "2018-01-01"));
            l_rule_licenseName.Add(new license_rule_entity("licdate1", "", 1, 3));

            l_rule.Add(new rule(39, "ruledate2", -1, -1, "", -1, "", "2016-06-20"));
            l_rule_licenseName.Add(new license_rule_entity("licdate2", "", 1, 3));

            l_rule.Add(new rule(40, "ruledate3", -1, -1, "", -1, "2016-06-21", "2016-06-21"));
            l_rule_licenseName.Add(new license_rule_entity("licdate3", "", 1, 3));





        }
        [TestMethod()]
        public void get_rule_v2Test_1()
        {
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("mojeLux1", "ruleLux", 1, 1, "kaleLux", "nike", -1, -1, -1, -1, -1, -1));
            l_rule_entity_good.Add(new license_rule_entity("mojeLux2", "ruleLux", 2, 1, "kaleLux", "nike", -1, -1, -1, -1, -1, -1));



            List<rule> l_rule = new List<rule>();

            //
            good g = new good("kaleLux", "nike", 1, 1, 1);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_entity_good, l_rule, "true");
            actualLicenseResult.Add("mojeLux1");
            actualLicenseResult.Add("mojeLux2");

            CollectionAssert.AreEqual(testResult, actualLicenseResult);
        
        }
        [TestMethod()]
        public void get_rule_v2Test_2()
        {

          
            

          

            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("liccomp1", "ruleLux", 1, 2, "shoe", "nike", -1, -1, -1, -1, -1, -1));
            l_rule_entity_good.Add(new license_rule_entity("lictotalval2", "ruleLux", 2, 2, "shoe", "nike", -1, -1, -1, -1, -1, -1));
            l_rule_entity_good.Add(new license_rule_entity("licdate1", "ruleLux", 3, 2, "shoe", "nike", -1, -1, -1, -1, -1, -1));
            l_rule_entity_good.Add(new license_rule_entity("licdate3", "ruleLux", 4, 2, "shoe", "nike", -1, -1, -1, -1, -1, -1));
          

            List<rule> l_rule = new List<rule>();

            //
            good g = new good("shoe", "nike", 1, 1, 1);
            List<good> glist = new List<good>();
            glist.Add(g);

            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            //testResult = rc.get_rule_("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist);
            actualLicenseResult.Add("liccomp1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            var msg = string.Join(Environment.NewLine, testResult);
            var msg2 = string.Join(Environment.NewLine, actualLicenseResult);

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_entity_good, l_rule, "true");
          
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
        [TestMethod()]
        public void get_rule_v2Test_3()
        {


            setRule();
            good g = new good("shoe", "adidas", 1, 1, 1);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
           
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

           // l_rule_entity_good.Add(new license_rule_entity("lictotalval2", "", 1, 3));
           // l_rule_entity_good.Add(new license_rule_entity("licdate1", "", 2, 3));
           // l_rule_entity_good.Add(new license_rule_entity("licdate3", "", 3, 3));
             
            //get_rule_v2(string _bizManSsn, string _date, int _totalVal, string _originCountry, int _transType, List<good> goodList, List<license_rule_entity> in_l_lic_rule_good, List<license_rule_entity> in_l_lic_rule, List<rule> in_l_rule, string isTest)


            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_licenseName, l_rule_licenseName, l_rule, "true");
            //if(testResult.Count == actualLicenseResult.Count)
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
        [TestMethod()]
        public void get_rule_v2Test_4()
        {
            setRule();
            good g = new good("computer", "asus", 1, 1, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");


            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("liccount1", "", 1, 2, "computer", "", -1, -1, 10, 1000, -1, -1));



            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");

            CollectionAssert.AreEqual(testResult, actualLicenseResult);

          
        }



        [TestMethod()]
        public void get_rule_v2Test_5()
        {

            setRule();

            good g = new good("computer", "asus", 1, 200, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("liccount1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();

         
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("liccount1", "", 1, 2, "computer", "", -1, -1, 10, 1000, -1, -1));



            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");

            CollectionAssert.AreEqual(testResult, actualLicenseResult);

           

        }

        [TestMethod()]
        public void get_rule_v2Test_6()
        {

            setRule();
            good g = new good("pen", "uniball", 1, 40000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("liccount2");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();

            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("liccount2", "", 1, 2, "pen", "", -1, -1, -1, 40000, -1, -1));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");

            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }

        [TestMethod()]
        public void get_rule_v2Test_7()
        {

            setRule();
            good g = new good("headphone", "sony", 1, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("liccount3");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();

            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("liccount3", "", 1, 2, "headphone", "", -1, -1, 1000, -1, -1, -1));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
        
        [TestMethod()]
        public void get_rule_v2Test_8()
        {

            setRule();

            good g = new good("rice", "mohsen", 6001, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");


            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licweight1", "", 1, 2, "rice", "mohsen", 3000, 6000, -1, -1, -1, -1));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");


            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
        [TestMethod()]
        public void get_rule_v2Test_9()
        {

            setRule();

            good g = new good("shampoo", "clear", 50, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");

            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licweight2", "", 1, 2, "shampoo", "", 100, -1, -1, -1, -1, -1));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");

            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
        [TestMethod()]
        public void get_rule_v2Test_10()
        {

            setRule();

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
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licweight3", "", 1, 2, "date", "", -1, 1500, -1, -1, -1, -1));
            l_rule_entity_good.Add(new license_rule_entity("licweight4", "", 1, 2, "date", "", -1, 1500, -1, -1, -1, -1));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
        [TestMethod()]
        public void get_rule_v2Test_11()
        {

            setRule();
            good g = new good("bag", "adidas", 800, 1000, 1000);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();

            actualLicenseResult.Add("licweight5");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();

            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licweight5", "", 1, 2, "bag", "", -1, -1, -1, -1, -1, -1));
           
            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");

            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
        public void get_rule_v2Test_12()
        {

            setRule();
            good g = new good("flash", "transcend", 800, 1000, 300);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("licprice1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");

            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licprice1", "", 1, 2, "flash", "", -1, -1, -1, -1, 200, 300));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
        public void get_rule_v2Test_13()
        {

            setRule();
            good g = new good("adultcold", "abidi", 800, 1000, 1200);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licprice2", "", 1, 2, "adultcold", "", -1, -1, -1, -1, -1, 1000));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
        public void get_rule_v2Test_14()
        {

            setRule();
            good g = new good("shirt", "adidas", 800, 1000, 700);
            List<good> glist = new List<good>();
            glist.Add(g);
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licprice3", "", 1, 2, "shirt", "", -1, -1, -1, -1, 800, -1));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
        public void get_rule_v2Test_15()
        {

            setRule();
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
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licprice4", "", 1, 2, "chips", "", -1, -1, -1, -1, -1, -1));
            l_rule_entity_good.Add(new license_rule_entity("licprice5", "", 1, 2, "chips", "", -1, -1, -1, -1, -1, -1));

            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
        public void get_rule_v2Test_16()
        {

            setRule();
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
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();
            l_rule_entity_good.Add(new license_rule_entity("licname1", "", 1, 2, "", "toyota", -1, -1, -1, -1, -1, -1));
            l_rule_entity_good.Add(new license_rule_entity("licname1", "", 1, 2, "", "hyundai", -1, -1, -1, -1, -1, -1));
            testResult = rc.get_rule_v2("1", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china", 0, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");

             CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
        public void get_rule_v2Test_17()
        {

            setRule();
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("lictrans1");
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();
            
            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

            testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "china", 2, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
        public void get_rule_v2Test_18()
        {

            setRule();
            List<good> glist = new List<good>();
            List<String> actualLicenseResult = new List<String>();
            actualLicenseResult.Add("lictotalval2");
            actualLicenseResult.Add("licdate1");
            actualLicenseResult.Add("licdate3");
            List<String> testResult = new List<String>();

            List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

            testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "china", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
            CollectionAssert.AreEqual(testResult, actualLicenseResult);

        }
         [TestMethod()]
         public void get_rule_v2Test_19()
         {

             setRule();
             List<good> glist = new List<good>();
             List<String> actualLicenseResult = new List<String>();
             actualLicenseResult.Add("licountry1");
             actualLicenseResult.Add("lictotalval2");
             actualLicenseResult.Add("licdate1");
             actualLicenseResult.Add("licdate3");
             List<String> testResult = new List<String>();
             List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

             testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "sweden", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
             CollectionAssert.AreEqual(testResult, actualLicenseResult);

         }
         [TestMethod()]
         public void get_rule_v2Test_20()
         {

             setRule();
             List<good> glist = new List<good>();
             List<String> actualLicenseResult = new List<String>();
             actualLicenseResult.Add("lictotalval2");
             actualLicenseResult.Add("licdate1");
             actualLicenseResult.Add("licdate3");
             List<String> testResult = new List<String>();
             List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

             testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 200, "china", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
             CollectionAssert.AreEqual(testResult, actualLicenseResult);

         }
         [TestMethod()]
         public void get_rule_v2Test_21()
         {

             setRule();
             List<good> glist = new List<good>();
             List<String> actualLicenseResult = new List<String>();
             actualLicenseResult.Add("lictotalval1");
             actualLicenseResult.Add("lictotalval2");
             actualLicenseResult.Add("licdate1");
             actualLicenseResult.Add("licdate3");
             List<String> testResult = new List<String>();
             List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

             testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 2000, "china", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
             CollectionAssert.AreEqual(testResult, actualLicenseResult);

         }
         [TestMethod()]
         public void get_rule_v2Test_22()
         {

             setRule();
             List<good> glist = new List<good>();
             List<String> actualLicenseResult = new List<String>();
             actualLicenseResult.Add("lictotalval2");
             actualLicenseResult.Add("lictotalval3");
             actualLicenseResult.Add("licdate1");
             actualLicenseResult.Add("licdate3");
             List<String> testResult = new List<String>();
             List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

             testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 5000, "china", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
             CollectionAssert.AreEqual(testResult, actualLicenseResult);

         }
         [TestMethod()]
         public void get_rule_v2Test_23()
         {

             setRule();
             List<good> glist = new List<good>();
             List<String> actualLicenseResult = new List<String>();
             actualLicenseResult.Add("lictotalval2");
             actualLicenseResult.Add("licdate1");
             actualLicenseResult.Add("licdate3");
             List<String> testResult = new List<String>();
             List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

             testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 499, "china", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
             CollectionAssert.AreEqual(testResult, actualLicenseResult);


         }
         [TestMethod()]
         public void get_rule_v2Test_24()
         {

             setRule();
             List<good> glist = new List<good>();
             List<String> actualLicenseResult = new List<String>();
             actualLicenseResult.Add("lictotalval3");
             actualLicenseResult.Add("licdate1");
             actualLicenseResult.Add("licdate3");
             List<String> testResult = new List<String>();
             List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

             testResult = rc.get_rule_v2("2", DateTime.Now.ToString("yyyy-MM-dd"), 6000, "china", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
             CollectionAssert.AreEqual(testResult, actualLicenseResult);

         }
         [TestMethod()]
         public void get_rule_v2Test_25()
         {

             setRule();
             List<good> glist = new List<good>();
             List<String> actualLicenseResult = new List<String>();
             actualLicenseResult.Add("lictotalval3");
            
             List<String> testResult = new List<String>();
             List<license_rule_entity> l_rule_entity_good = new List<license_rule_entity>();

             testResult = rc.get_rule_v2("2","2020-10-10", 6000, "china", 1, glist, l_rule_entity_good, l_rule_licenseName, l_rule, "true");
             CollectionAssert.AreEqual(testResult, actualLicenseResult);

         }
         
    }
}
