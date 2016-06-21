using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.Entity;
using gomrok.DB;
using gomrok;
using System.Data.SQLite;
using WindowsFormsApplication2.Entity;

namespace gomrok.ctrller
{
    public class ruleCtrl
    {
        database db = database.getDataBase();
        ruleTable _ruleTable = ruleTable.get_rule_table();
        licenseDesContainer ldc = new licenseDesContainer();
        licenseDesCtrl ld = new licenseDesCtrl();
        public List<int> ids = new List<int>();
        public int ruleID;


        public ruleCtrl()
        {
            ruleID = get_ruleID();
        }
        internal Tuple<List<license_rule_entity>, List<rule>> makeObj_ruleDec()
        {
            List<license_rule_entity> l_lic_rule = new List<license_rule_entity>();
            List<rule> l_rule = new List<rule>();
            //for declaration
            SQLiteDataReader reader = _ruleTable.get_rule_dec();
            while (reader.Read())
            {
                // (int _ruleID, string _rulename, int _min_totalVal, int _max_totalVal, string _originCountry, int _transType, string _start_date, string _finish_date)
                rule r = new rule(Convert.ToInt32(reader["ruleID"]), (String)reader["ruleName"], Convert.ToInt32(reader["min_total_value"]), Convert.ToInt32(reader["max_total_value"]), (String)reader["origin_country"], Convert.ToInt32(reader["transType"]), (String)reader["start_date"], (String)reader["finish_date"]);
                l_rule.Add(r);
                license_rule_entity lre = new license_rule_entity((String)reader["licensename"], (String)reader["ruleName"], Convert.ToInt32(reader["licenseID"]), Convert.ToInt32(reader["ruleID"]));
                l_lic_rule.Add(lre);
            }
            //for good
            //  public goodRule(string _name, string _com, int _min_weight, int _max_weight, int _min_qnty, int _max_qnty, int _min_unitPrice, int _max_unitPrice)

            return Tuple.Create(l_lic_rule, l_rule);
        }
        internal List<license_rule_entity> makeObj_ruleGoods(string goodName)
        {
            List<license_rule_entity> l_lic_rule = new List<license_rule_entity>();
            List<goodRule> l_rule_goods = new List<goodRule>();
            //for goods (declaration)

            // (string _lname, string _rname, int _lId, int _rId, string _name, string _com, int _min_weight, int _max_weight, int _min_qnty, int _max_qnty, int _min_unitPrice, int _max_unitPrice, int pk) 
            SQLiteDataReader reader = _ruleTable.get_rule_good(goodName);
            while (reader.Read())
            {

                license_rule_entity lre = new license_rule_entity((String)reader["licensename"], "rulename", Convert.ToInt32(reader["licenseID"]), Convert.ToInt32(reader["ID"]), (String)reader["name"], (String)reader["producer_company"], Convert.ToInt32(reader["min_weight"]), Convert.ToInt32(reader["max_weight"]), Convert.ToInt32(reader["min_qnty"]), Convert.ToInt32(reader["max_qnty"]), Convert.ToInt32(reader["min_unitPrice"]), Convert.ToInt32(reader["max_unitPrice"]));

                l_lic_rule.Add(lre);
            }

            return l_lic_rule;
        }
        internal Tuple<List<license_rule_entity>, List<goodRule>> makeObj_rulenotGoods()
        {
            List<license_rule_entity> l_lic_rule = new List<license_rule_entity>();
            List<goodRule> l_rule_goods = new List<goodRule>();
            //for goods (declaration)
            SQLiteDataReader reader = _ruleTable.get_rule_notgood();
            while (reader.Read())
            {
                // (int _ruleID, string _rulename, int _min_totalVal, int _max_totalVal, string _originCountry, int _transType, string _start_date, string _finish_date)
                goodRule gr = new goodRule((String)reader["name"], (String)reader["producer_company"], Convert.ToInt32(reader["min_weight"]), Convert.ToInt32(reader["max_weight"]), Convert.ToInt32(reader["min_qnty"]), Convert.ToInt32(reader["max_qnty"]), Convert.ToInt32(reader["min_unitPrice"]), Convert.ToInt32(reader["max_unitPrice"]));
                l_rule_goods.Add(gr);
                license_rule_entity lre = new license_rule_entity((String)reader["licensename"], "rulename", Convert.ToInt32(reader["licenseID"]), Convert.ToInt32(reader["ID"]));
                l_lic_rule.Add(lre);
            }
            //for good
            //  public goodRule(string _name, string _com, int _min_weight, int _max_weight, int _min_qnty, int _max_qnty, int _min_unitPrice, int _max_unitPrice)

            return Tuple.Create(l_lic_rule, l_rule_goods);
        }
        public List<string> get_rule_v2(string _bizManSsn, string _date, int _totalVal, string _originCountry, int _transType, List<good> goodList, List<license_rule_entity> in_l_lic_rule_good, List<license_rule_entity> in_l_lic_rule, List<rule> in_l_rule, string isTest)
        {
            List<String> licenseNameList = new List<string>();
            List<license_rule_entity> l_lic_rule = new List<license_rule_entity>();
            List<rule> l_rule = new List<rule>();

            if (isTest == "false")
            {
                l_lic_rule = makeObj_ruleDec().Item1;
                l_rule = makeObj_ruleDec().Item2;
            }
            else if (isTest == "true")
            {
                l_lic_rule = in_l_lic_rule;
                l_rule = in_l_rule;
                

            }
            // makeObj_ruleGoods(string goodName)

            foreach (good g in goodList)
            {
                //goodname
                String goodName = g.goodName;

                List<license_rule_entity> l_good_rule = new List<license_rule_entity>();
                // List<goodRule> l_good_rule = new List<goodRule>();
               
                if (isTest == "false")
                {
                    //l_lic_rule_good = makeObj_ruleGoods(goodName);
                    l_good_rule = makeObj_ruleGoods(goodName);
                }

                else if (isTest == "true")
                {

                    l_good_rule = in_l_lic_rule_good;
                    //l_lic_rule_good = in_l_lic_rule_good;
                }
                MessageBox.Show("testing.........\n ruleKoli:  " + l_rule.Count + "\n ruleGood" + l_good_rule.Count + "/");

                // if rulegoodTable has value for good field check if equals or in range
                String declared_goodCompany = g.company;
                int declared_goodWeight = g.weight;
                int declared_goodQnty = g.qnty;
                int declared_goodUnitPrice = g.unitPrice;
                ///////////


                for (int j = 0; j < l_good_rule.Count; j++)
                {

                    String rule_goodCompany = l_good_rule[j].company;
                    int rule_min_goodWeight = l_good_rule[j].min_weight;
                    int rule_max_goodWeight = l_good_rule[j].max_weight;

                    int rule_min_goodQnty = l_good_rule[j].min_qnty;
                    int rule_max_goodQnty = l_good_rule[j].max_qnty;

                    int rule_min_goodUprice = l_good_rule[j].min_unitPrice;
                    int rule_max_goodUprice = l_good_rule[j].max_unitPrice;


                    /////////////////
                    int comMatch = 0, minQntyMatch = 0, maxQntyMatch = 0, minWeightMatch = 0, maxWeightMatch = 0, minUp = 0, maxUp = 0;
                    //company
                    if (!string.IsNullOrEmpty(rule_goodCompany))
                    {

                        if (!string.IsNullOrEmpty(declared_goodCompany))
                            if (rule_goodCompany == declared_goodCompany)
                            {
                                //MessageBox.Show("company matches\t:    " + (String)reader["licensename"]);
                                //licenseNameList.Add((String)reader["licensename"]);
                                comMatch = 1;

                            }
                    }
                    else if (string.IsNullOrEmpty(rule_goodCompany))
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        comMatch = 1;
                    }

                    //weight
                    if (declared_goodWeight != -1 && rule_min_goodWeight != -1 && rule_max_goodWeight != -1)
                    {
                        if (declared_goodWeight >= rule_min_goodWeight && declared_goodWeight <= rule_max_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }
                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight != -1 && rule_min_goodWeight == -1)
                    {
                        if (declared_goodWeight <= rule_max_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }

                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight == -1 && rule_min_goodWeight != -1)
                    {
                        if (declared_goodWeight >= rule_min_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }
                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight == -1 && rule_min_goodWeight == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minWeightMatch = 1;
                        maxWeightMatch = 1;

                    }//end weight

                    //quantity
                    
                    if (declared_goodQnty != -1 && rule_min_goodQnty != -1 && rule_max_goodQnty != -1)
                    {
                        if (declared_goodQnty >= rule_min_goodQnty && declared_goodQnty <= rule_max_goodQnty)
                        {

                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }
                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty != -1 && rule_min_goodQnty == -1)
                    {
                        if (declared_goodQnty <= rule_max_goodQnty)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }

                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty == -1 && rule_min_goodQnty != -1)
                    {
                        if (declared_goodQnty >= rule_min_goodQnty)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }

                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty == -1 && rule_max_goodQnty == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minQntyMatch = 1;
                        maxQntyMatch = 1;
                    }

                    //end quanity

                    //unit price
                    if (declared_goodUnitPrice != -1 && rule_min_goodUprice != -1 && rule_max_goodUprice != -1)
                    {
                        if (declared_goodUnitPrice >= rule_min_goodUprice && declared_goodUnitPrice <= rule_max_goodUprice)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;

                        }
                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice != -1 && rule_min_goodUprice == -1)
                    {
                        if (declared_goodUnitPrice <= rule_max_goodUprice)
                        {
                            // licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;


                        }

                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice == -1 && rule_min_goodUprice != -1)
                    {
                        if (declared_goodUnitPrice >= rule_min_goodUprice)
                        {
                            // licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;


                        }
                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice == -1 && rule_min_goodUprice == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minUp = 1;
                        maxUp = 1;


                    }//unit Price

                    string licenseName_good = l_good_rule[j].licName;
                    if (comMatch == 1 && minUp == 1 && maxUp == 1 && minWeightMatch == 1 && maxWeightMatch == 1 && minQntyMatch == 1 && maxQntyMatch == 1)
                    {
                        MessageBox.Show("مجوز کالا" + licenseName_good);
                        licenseNameList.Add(licenseName_good);
                    }
                }





            }




            //declaration detail
            //MessageBox.Show( "/" + l_rule.Count);

            for (int i = 0; i < l_rule.Count; i++)
            {
                //MessageBox.Show("i" + i + "/" + l_rule.Count);

               // MessageBox.Show(l_rule[i].rulename + "/" + l_rule[i].start_date + "/" + l_rule[i].finish_date + "/" + l_rule[i].min_totalVal + "/" + l_rule[i].max_totalVal);



                //date
                string rule_finishDate = null, rule_startDate = null, rule_originCountry = null;
                int rule_transType = -1, rule_minTotalVal = -1, rule_maxTotalVal = -1;
                rule_finishDate = l_rule[i].finish_date;
                rule_startDate = l_rule[i].start_date;
                rule_originCountry = l_rule[i].originCountry;
                rule_transType = l_rule[i].transType;
                rule_maxTotalVal = l_rule[i].max_totalVal;
                rule_minTotalVal = l_rule[i].min_totalVal;
               // MessageBox.Show("ruledates:\t" + rule_startDate + "/" + rule_finishDate );
                int dateMatch = 0, totalValMatch = 0, countryMatch = 0, transMatch = 0;
                if (!string.IsNullOrEmpty(_date) && !string.IsNullOrEmpty(rule_startDate) && !string.IsNullOrEmpty(rule_finishDate))
                {
                    //MessageBox.Show("date\t" + _date + "\t | \t" + (String)reader_otherField["start_date"]);
                    if (string.Compare(_date, rule_startDate) >= 0 && string.Compare(_date, rule_finishDate) <= 0)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        dateMatch = 1;
                    }
                    else
                        dateMatch = -1;
                }

                else if (!string.IsNullOrEmpty(_date) && string.IsNullOrEmpty(rule_startDate) && !string.IsNullOrEmpty(rule_finishDate))
                {
                    if (string.Compare(_date, rule_finishDate) <= 0)
                    {
                        // licenseNameList.Add((String)reader_otherField["licensename"]);
                        dateMatch = 1;

                    }
                    else
                        dateMatch = -1;
                }
                else if (!string.IsNullOrEmpty(_date) && string.IsNullOrEmpty(rule_finishDate) && !string.IsNullOrEmpty(rule_startDate))
                {
                    if (string.Compare(_date, rule_finishDate) >= 0)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        dateMatch = 1;
                    }
                    else
                        dateMatch = -1;
                }
                //end date



                //country
                if (!string.IsNullOrEmpty(_originCountry) && !string.IsNullOrEmpty(rule_originCountry))
                {
                    if (_originCountry == rule_originCountry)
                    {
                        //MessageBox.Show("dec\t" + _originCountry + "|rule\t" + rule_originCountry);
                        // MessageBox.Show("dec_origin matches\t:    " + (String)reader_otherField["licensename"]);
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        countryMatch = 1;
                    }
                    else
                        countryMatch = -1;
                }


                //transType
                if (rule_transType != -1 && _transType != -1)
                {
                    if (_transType == rule_transType)
                    {
                        // MessageBox.Show("dec_transType matches\t:    " + (String)reader_otherField["licensename"]);
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        transMatch = 1;
                    }
                    else
                        transMatch = -1;

                }


                //totalValue
                if (rule_minTotalVal != -1 && rule_maxTotalVal != -1)
                {
                    if (rule_minTotalVal <= _totalVal && rule_maxTotalVal >= _totalVal)
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        totalValMatch = 1;
                    else
                        totalValMatch = -1;

                }
                else if (rule_minTotalVal != -1 && rule_maxTotalVal == -1 && _totalVal != -1)
                {
                    if (rule_minTotalVal <= _totalVal)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        totalValMatch = 1;

                    }
                    else
                        totalValMatch = -1;

                }
                else if (rule_maxTotalVal != -1 && rule_minTotalVal == -1 && _totalVal != -1)
                {
                    if (rule_maxTotalVal >= _totalVal)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        totalValMatch = 1;

                    }
                    else
                        totalValMatch = -1;

                }
                //end totalValue

                string licenseName = l_lic_rule[i].licName;
                if (countryMatch != -1 && totalValMatch != -1 && transMatch != -1 && dateMatch != -1)
                {
                    MessageBox.Show("مجوز" + "  " + licenseName);
                    licenseNameList.Add(licenseName);
                }

            }
            licenseNameList = licenseNameList.Distinct().ToList();
            return licenseNameList;


        }
        public List<string> get_rule_(string _bizManSsn, string _date, int _totalVal, string _originCountry, int _transType, List<good> goodList)
        {
            List<String> licenseNameList = new List<string>();
            ruleTable rt = ruleTable.get_rule_table();
            SQLiteDataReader reader_otherField;
            foreach (good g in goodList)
            {
                //goodname
                String goodName = g.goodName;
                SQLiteDataReader reader;
                reader = rt.get_rule_good(g.goodName);


                // if rulegoodTable has value for good field check if equals or in range
                String declared_goodCompany = g.company;
                int declared_goodWeight = g.weight;
                int declared_goodQnty = g.qnty;
                int declared_goodUnitPrice = g.unitPrice;
                ///////////


                while (reader.Read())
                {
                    //tmp_licenseName = reader.GetString(0);
                    //System.Int64 tmp = (System.Int64)reader["userType"];
                    MessageBox.Show("in while");
                    String rule_goodCompany = (String)reader["producer_company"];
                    int rule_min_goodWeight = Convert.ToInt32(reader["min_weight"]);
                    int rule_max_goodWeight = Convert.ToInt32(reader["max_weight"]);

                    int rule_min_goodQnty = Convert.ToInt32(reader["min_qnty"]);
                    int rule_max_goodQnty = Convert.ToInt32(reader["max_qnty"]);

                    int rule_min_goodUprice = Convert.ToInt32(reader["min_unitprice"]);
                    int rule_max_goodUprice = Convert.ToInt32(reader["max_unitprice"]);

                    /////////////////
                    int comMatch = 0, minQntyMatch = 0, maxQntyMatch = 0, minWeightMatch = 0, maxWeightMatch = 0, minUp = 0, maxUp = 0;
                    //company
                    if (!string.IsNullOrEmpty(rule_goodCompany))
                    {

                        if (!string.IsNullOrEmpty(declared_goodCompany))
                            if (rule_goodCompany == declared_goodCompany)
                            {
                                MessageBox.Show("company matches\t:    " + (String)reader["licensename"]);
                                //licenseNameList.Add((String)reader["licensename"]);
                                comMatch = 1;

                            }
                    }
                    else if (string.IsNullOrEmpty(rule_goodCompany))
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        comMatch = 1;
                    }

                    //weight
                    if (declared_goodWeight != -1 && rule_min_goodWeight != -1 && rule_max_goodWeight != -1)
                    {
                        if (declared_goodWeight >= rule_min_goodWeight && declared_goodWeight <= rule_max_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }
                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight != -1 && rule_min_goodWeight == -1)
                    {
                        if (declared_goodWeight <= rule_max_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }

                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight == -1 && rule_min_goodWeight != -1)
                    {
                        if (declared_goodWeight >= rule_min_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }
                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight == -1 && rule_min_goodWeight == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minWeightMatch = 1;
                        maxWeightMatch = 1;

                    }//end weight

                    //quantity
                    MessageBox.Show("fuckyou" + rule_max_goodQnty + "/" + rule_min_goodQnty);
                    if (declared_goodQnty != -1 && rule_min_goodQnty != -1 && rule_max_goodQnty != -1)
                    {
                        if (declared_goodQnty >= rule_min_goodQnty && declared_goodQnty <= rule_max_goodQnty)
                        {

                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }
                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty != -1 && rule_min_goodQnty == -1)
                    {
                        if (declared_goodQnty <= rule_max_goodQnty)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }

                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty == -1 && rule_min_goodQnty != -1)
                    {
                        if (declared_goodQnty >= rule_min_goodQnty)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }

                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty == -1 && rule_max_goodQnty == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minQntyMatch = 1;
                        maxQntyMatch = 1;
                    }

                    //end quanity

                    //unit price
                    if (declared_goodUnitPrice != -1 && rule_min_goodUprice != -1 && rule_max_goodUprice != -1)
                    {
                        if (declared_goodUnitPrice >= rule_min_goodUprice && declared_goodUnitPrice <= rule_max_goodUprice)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;

                        }
                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice != -1 && rule_min_goodUprice == -1)
                    {
                        if (declared_goodUnitPrice <= rule_max_goodUprice)
                        {
                            // licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;


                        }

                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice == -1 && rule_min_goodUprice != -1)
                    {
                        if (declared_goodUnitPrice >= rule_min_goodUprice)
                        {
                            // licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;


                        }
                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice == -1 && rule_min_goodUprice == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minUp = 1;
                        maxUp = 1;


                    }//unit Price

                    if (comMatch == 1 && minUp == 1 && maxUp == 1 && minWeightMatch == 1 && maxWeightMatch == 1 && minQntyMatch == 1 && maxQntyMatch == 1)
                    {
                        licenseNameList.Add((String)reader["licensename"]);
                    }
                }
                /////////////////////////////////
                SQLiteDataReader reader_2;
                reader_2 = rt.get_rule_notgood();


                // if rulegoodTable has value for good field check if equals or in range



                while (reader_2.Read())
                {
                    //tmp_licenseName = reader.GetString(0);
                    //System.Int64 tmp = (System.Int64)reader["userType"];
                    MessageBox.Show("in while");
                    String rule_goodCompany = (String)reader_2["producer_company"];
                    int rule_min_goodWeight = Convert.ToInt32(reader_2["min_weight"]);
                    int rule_max_goodWeight = Convert.ToInt32(reader_2["max_weight"]);

                    int rule_min_goodQnty = Convert.ToInt32(reader_2["min_qnty"]);
                    int rule_max_goodQnty = Convert.ToInt32(reader_2["max_qnty"]);

                    int rule_min_goodUprice = Convert.ToInt32(reader_2["min_unitprice"]);
                    int rule_max_goodUprice = Convert.ToInt32(reader_2["max_unitprice"]);

                    /////////////////
                    int comMatch = 0, minQntyMatch = 0, maxQntyMatch = 0, minWeightMatch = 0, maxWeightMatch = 0, minUp = 0, maxUp = 0;
                    //company
                    if (!string.IsNullOrEmpty(rule_goodCompany))
                    {

                        if (!string.IsNullOrEmpty(declared_goodCompany))
                            if (rule_goodCompany == declared_goodCompany)
                            {
                                MessageBox.Show("company matches\t:    " + (String)reader_2["licensename"]);
                                //licenseNameList.Add((String)reader["licensename"]);
                                comMatch = 1;

                            }
                    }
                    else if (string.IsNullOrEmpty(rule_goodCompany))
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        comMatch = 1;
                    }

                    //weight
                    if (declared_goodWeight != -1 && rule_min_goodWeight != -1 && rule_max_goodWeight != -1)
                    {
                        if (declared_goodWeight >= rule_min_goodWeight && declared_goodWeight <= rule_max_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }
                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight != -1 && rule_min_goodWeight == -1)
                    {
                        if (declared_goodWeight <= rule_max_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }

                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight == -1 && rule_min_goodWeight != -1)
                    {
                        if (declared_goodWeight >= rule_min_goodWeight)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minWeightMatch = 1;
                            maxWeightMatch = 1;

                        }
                    }
                    else if (declared_goodWeight != -1 && rule_max_goodWeight == -1 && rule_min_goodWeight == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minWeightMatch = 1;
                        maxWeightMatch = 1;

                    }//end weight

                    //quantity
                    MessageBox.Show("fuckyou" + rule_max_goodQnty + "/" + rule_min_goodQnty);

                    if (declared_goodQnty != -1 && rule_min_goodQnty != -1 && rule_max_goodQnty != -1)
                    {
                        if (declared_goodQnty >= rule_min_goodQnty && declared_goodQnty <= rule_max_goodQnty)
                        {

                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }
                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty != -1 && rule_max_goodQnty == -1)
                    {
                        if (declared_goodQnty <= rule_max_goodQnty)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }

                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty == -1 && rule_min_goodQnty != -1)
                    {
                        if (declared_goodQnty >= rule_min_goodQnty)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minQntyMatch = 1;
                            maxQntyMatch = 1;

                        }

                    }
                    else if (declared_goodQnty != -1 && rule_max_goodQnty == -1 && rule_max_goodQnty == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minQntyMatch = 1;
                        maxQntyMatch = 1;
                    }

                    //end quanity

                    //unit price
                    if (declared_goodUnitPrice != -1 && rule_min_goodUprice != -1 && rule_max_goodUprice != -1)
                    {
                        if (declared_goodUnitPrice >= rule_min_goodUprice && declared_goodUnitPrice <= rule_max_goodUprice)
                        {
                            //licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;

                        }
                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice != -1 && rule_min_goodUprice == -1)
                    {
                        if (declared_goodUnitPrice <= rule_max_goodUprice)
                        {
                            // licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;


                        }

                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice == -1 && rule_min_goodUprice != -1)
                    {
                        if (declared_goodUnitPrice >= rule_min_goodUprice)
                        {
                            // licenseNameList.Add((String)reader["licensename"]);
                            minUp = 1;
                            maxUp = 1;


                        }
                    }
                    else if (declared_goodUnitPrice != -1 && rule_max_goodUprice == -1 && rule_min_goodUprice == -1)
                    {
                        //licenseNameList.Add((String)reader["licensename"]);
                        minUp = 1;
                        maxUp = 1;


                    }//unit Price

                    if (comMatch == 1 && minUp == 1 && maxUp == 1 && minWeightMatch == 1 && maxWeightMatch == 1 && minQntyMatch == 1 && maxQntyMatch == 1)
                    {
                        licenseNameList.Add((String)reader_2["licensename"]);
                    }
                }


            }//for loop on goodList
            //}


            //exceute query to check other parameter 

            reader_otherField = rt.get_rule_dec();

            //string _bizManSsn, string _date, string _totalVal, string _originCountry, string _transType
            while (reader_otherField.Read())
            {
                //date
                MessageBox.Show("in while2");
                int dateMatch = 0, totalValMatch = 0, countryMatch = 0, transMatch = 0;
                if (!string.IsNullOrEmpty(_date) && !string.IsNullOrEmpty((String)reader_otherField["start_date"]) && !string.IsNullOrEmpty((String)reader_otherField["finish_date"]))
                {
                    //MessageBox.Show("date\t" + _date + "\t | \t" + (String)reader_otherField["start_date"]);
                    if (string.Compare(_date, (String)reader_otherField["start_date"]) >= 0 && string.Compare(_date, (String)reader_otherField["finish_date"]) <= 0)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        dateMatch = 1;
                    }
                    else
                        dateMatch = -1;
                }

                else if (!string.IsNullOrEmpty(_date) && string.IsNullOrEmpty((String)reader_otherField["start_date"]) && !string.IsNullOrEmpty((String)reader_otherField["finish_date"]))
                {
                    if (string.Compare(_date, (String)reader_otherField["finish_date"]) <= 0)
                    {
                        // licenseNameList.Add((String)reader_otherField["licensename"]);
                        dateMatch = 1;

                    }
                    else
                        dateMatch = -1;
                }
                else if (!string.IsNullOrEmpty(_date) && string.IsNullOrEmpty((String)reader_otherField["finish_date"]) && !string.IsNullOrEmpty((String)reader_otherField["start_date"]))
                {
                    if (string.Compare(_date, (String)reader_otherField["start_date"]) >= 0)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        dateMatch = 1;
                    }
                    else
                        dateMatch = -1;
                }
                //end date

                //country
                if (!string.IsNullOrEmpty(_originCountry) && !string.IsNullOrEmpty((String)reader_otherField["origin_country"]))
                {
                    if (_originCountry == (String)reader_otherField["origin_country"])
                    {
                        MessageBox.Show("dec\t" + _originCountry + "|rule\t" + (String)reader_otherField["origin_country"]);
                        MessageBox.Show("dec_origin matches\t:    " + (String)reader_otherField["licensename"]);
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        countryMatch = 1;
                    }
                    else
                        countryMatch = -1;
                }
                //transType
                if (Convert.ToInt32(reader_otherField["transType"]) != -1 && _transType != -1)
                {
                    if (_transType == Convert.ToInt32(reader_otherField["transType"]))
                    {
                        MessageBox.Show("dec_transType matches\t:    " + (String)reader_otherField["licensename"]);
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        transMatch = 1;
                    }
                    else
                        transMatch = -1;

                }
                //totalValue
                if (Convert.ToInt32(reader_otherField["min_total_value"]) != -1 && Convert.ToInt32(reader_otherField["max_total_value"]) != -1)
                {
                    if (Convert.ToInt32(reader_otherField["min_total_value"]) <= _totalVal && Convert.ToInt32(reader_otherField["max_total_value"]) >= _totalVal)
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        totalValMatch = 1;
                    else
                        totalValMatch = -1;

                }
                else if (Convert.ToInt32(reader_otherField["min_total_value"]) != -1 && Convert.ToInt32(reader_otherField["max_total_value"]) == -1 && _totalVal != -1)
                {
                    if (Convert.ToInt32(reader_otherField["min_total_value"]) <= _totalVal)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        totalValMatch = 1;

                    }
                    else
                        totalValMatch = -1;

                }
                else if (Convert.ToInt32(reader_otherField["max_total_value"]) != -1 && Convert.ToInt32(reader_otherField["min_total_value"]) == -1 && _totalVal != -1)
                {
                    if (Convert.ToInt32(reader_otherField["max_total_value"]) >= _totalVal)
                    {
                        //licenseNameList.Add((String)reader_otherField["licensename"]);
                        totalValMatch = 1;

                    }
                    else
                        totalValMatch = -1;

                }
                //end totalValue
                if (countryMatch != -1 && totalValMatch != -1 && transMatch != -1 && dateMatch != -1)
                {
                    MessageBox.Show("reach");
                    licenseNameList.Add((String)reader_otherField["licensename"]);
                }

            }
            licenseNameList = licenseNameList.Distinct().ToList();
            MessageBox.Show(licenseNameList.Count + "siize");
            return licenseNameList;
        }
        //public List<string> get_rule(string _bizManSsn, string _date, int _totalVal, string _originCountry, int _transType, List<good> goodList)
        //{
        //    return _ruleTable.get_rule(_bizManSsn, _date, _totalVal, _originCountry, _transType, goodList);
        //}
        public List<string> get_licenseList()
        {
            int i = 0;
            List<string> items = new List<string>();
            foreach (licenseDescription l in ldc.list)
            {
                items.Add(l.licenseName + " " + l.orgName + "(" + i + ")");
                i++;
            }
            return items;
        }
        public List<int> confirmLicenseList()
        {
            int id, _id = -1;
            foreach (licenseDescription newld in ldc.list)
            {
                _id = -1;
                _id = ld.checkLicense(newld.licenseName);
                if (_id == -1)
                {
                    id = ld.addLicenseDesc(newld.licenseName, newld.orgName);
                    ids.Add(id);
                }
                else
                {
                    ids.Add(_id);
                }
            }
            return ids;
        }

        private void insert_new_rule(string rulename, string _start_date, string _finish_date, int min_totalVal, int max_totalVal, string _originCountry, int _transType)
        {
            _ruleTable.insert_new_rule(rulename, _start_date, _finish_date, min_totalVal, max_totalVal, _originCountry, _transType);
            _ruleTable.addLicense(ids, ruleID);
            MessageBox.Show("قانون جدید اضافه شد");

        }
        public void add_to_licenseList(string licenseName, string orgname)
        {
            licenseDescription newld = new licenseDescription(licenseName, orgname);
            ldc.addToLicDesContainer(newld);
        }
        internal void create_rule(String rulename, int _min_totalVal, int _max_totalVal, string _originCountry, int _transType, string _start_date, string _finish_date)
        {
            rule r = new rule(rulename, _min_totalVal, _max_totalVal, _originCountry, _transType, _start_date, _finish_date);
            insert_new_rule(rulename, _start_date, _finish_date, _min_totalVal, _max_totalVal, _originCountry, _transType);
        }


        private int get_ruleID()
        {
            return _ruleTable.get_ruleID() + 1;
        }

    }
}
