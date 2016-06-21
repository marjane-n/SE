using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.DB;
using gomrok.Entity;
namespace gomrok.ctrller
{
    class validationCtrl
    {
        database db = database.getDataBase();
        public validationTable vt = new validationTable();
        declaration declare;
        public List<license> licenses;
        public List<licenseMat> licensemats;
        licensesCtrl lc = new licensesCtrl();
        licenseMatsCtrl lmc = new licenseMatsCtrl();

        public validationCtrl(declaration dec)
        {
            declare = dec;
        }

        public int is_valid(List<string> needed, List<int> owned, List<good> gc)
        {
           if (vt.isBelonged(owned, declare.bizManSsn) == -1)
           {
               MessageBox.Show("همه مجوز های ارائه شده متعلق یه شما نمی باشند");

           }
           if(vt.gotAll(needed, owned, declare.bizManSsn) == -1)
           {
               MessageBox.Show("تاجر گرامی شما همه ی مجوز های مورد نیاز را ندارید");
           }
           licenses = vt.get_license_obj(owned);
           licensemats = vt.get_license_mat(owned);
           int retval = validateDec(owned, gc);
           return retval;
        }

        public int validateDec( List<int> owned, List<good> goods)
        {
            int cnt = 0, maxvalue = 0;
            declaration dec2 = new declaration();
            dec2 = declare;
            List<license> licenses2 = new List<license>();
            licenses2 = licenses;
            List<licenseMat> licensemats2 = new List<licenseMat>();
            licensemats2 = licensemats;
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            foreach (license li in licenses2)
            {
                if ((li.TypeOfTrans == -1 || (li.TypeOfTrans != -1 && li.TypeOfTrans == dec2.transType)) && (li.MinAmount == -1 || (li.MinAmount != -1 && li.MinAmount <= dec2.totalVal)) && (string.IsNullOrEmpty(li.EndDate) || !string.IsNullOrEmpty(li.EndDate) && String.Compare(li.EndDate, date) >= 0) && (string.IsNullOrEmpty(li.StartDate) || !string.IsNullOrEmpty(li.StartDate) && String.Compare(li.StartDate, date) <= 0) && (li.SrcCountry.Length == 0 || (!string.IsNullOrEmpty(li.StartDate) && String.Compare(li.SrcCountry, dec2.originCountry) == 0)))
                {
                    //////////////////////////////////////////
                    /*dec2.totalVal -= li.MaxAmount;*/
                    if (li.MaxAmount > maxvalue)
                        maxvalue = li.MaxAmount;

                    foreach (licenseMat lm in licensemats2)
                    {
                        if (lm.Lid == owned[cnt])
                        {
                            foreach (good g in goods)
                            {
                                if (g.goodName == lm.MName && (string.IsNullOrEmpty(lm.Mcomp) || !string.IsNullOrEmpty(lm.Mcomp) && g.company == lm.Mcomp) && (lm.MMinWeight == -1 || lm.MMinWeight != -1 && g.weight >= lm.MMinWeight) && (lm.MMinCount == -1 || lm.MMinCount != -1 && g.qnty >= lm.MMinCount) && (lm.MMaxFee == -1 || lm.MMaxFee != -1 && g.unitPrice <= lm.MMaxFee) && (lm.MMinFee == -1 || lm.MMinFee != -1 && g.unitPrice >= lm.MMinFee))
                                {
                                    if (lm.MMaxCount == -1)
                                    {
                                        g.qnty = 0;
                                    }
                                    if (lm.MMaxCount != -1 && g.qnty <= lm.MMaxCount)
                                    {
                                        lm.MMaxCount -= g.qnty;
                                        g.qnty = 0;
                                    }
                                    if (lm.MMaxCount != -1 && g.qnty > lm.MMaxCount)
                                    {
                                        g.qnty -= lm.MMaxCount;
                                        lm.MMaxCount = 0;
                                    }
                                    if (lm.MMaxWeight == -1)
                                    {
                                        g.weight = 0;
                                    }
                                    if (lm.MMaxWeight != -1 && g.weight <= lm.MMaxWeight)
                                    {
                                        lm.MMaxWeight -= g.weight;
                                        g.weight = 0;
                                    }
                                    if (lm.MMaxWeight != -1 && g.weight > lm.MMaxWeight)
                                    {
                                        g.qnty -= lm.MMaxWeight;
                                        lm.MMaxWeight = 0;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("good nashod ");
                                    //return -1;
                                }
                            }
                        }
                    }
                    /*if (dec2.totalVal <= li.MaxAmount)
                    {
                        dec2.totalVal = 0;
                        li.MaxAmount -= dec2.totalVal;
                    }
                    else
                    {
                        li.MaxAmount = 0;
                        dec2.totalVal -= li.MaxAmount;
                    }*/
                }
                else
                {
                    MessageBox.Show("mojavez nashod ");
                }
                cnt += 1;
            }

            foreach (good g in goods)
                if (g.qnty != 0 || g.weight != 0)
                {
                    MessageBox.Show("sefr nashod ");
                    return -1;
                }
            if (dec2.totalVal > maxvalue)
                return -1;
            lc.updateLicenses(licenses2, owned);
            lmc.updateLicenseMats(licensemats2);
            return 1;
        }
        
    }
}
