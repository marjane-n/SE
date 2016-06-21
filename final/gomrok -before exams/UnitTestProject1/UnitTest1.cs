using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using gomrok.Entity;
using gomrok.DB;
using gomrok;
using gomrok.ctrller;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ruleCtrl rc = new ruleCtrl();
        [TestMethod]
        public void TestMethod1()
        {
            //good(string _name, string _com, int _weight, int _qnty, int _unitPrice)
            //declaration info
            //List<string> get_rule(string _bizManSsn, string _date, int _totalVal, string _originCountry, int _transType, List<good> goodList)
            good g = new good("bag", "ck", 1, 1, 1);
            
            List<good> glist = new List<good>();
            glist.Add(g);
            //good g = new good();
            
            List<String> actualLicenseResult = new List<String>();
            List<String> testResult =  new List<String>();

            testResult = rc.get_rule_("1232523", DateTime.Now.ToString("yyyy-MM-dd"), 2, "china",0,glist);
            actualLicenseResult.Add("mojeBag");
           // Assert.AreEqual("mojeKala", "mojeKala");
            if (testResult.Count == actualLicenseResult.Count)
                CollectionAssert.AreEqual(actualLicenseResult, testResult);
            else
                Assert.AreEqual(1, 0);
        }
    }
}
