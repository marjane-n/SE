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
   class ruleGoodCtrl
    {
        database db = database.getDataBase();
        rulegoodTable _goodTable = rulegoodTable.get_good_table();
        goodRuleContainer gcon = new goodRuleContainer();

        public void add_good(string _name, string _com, int min_weight, int max_weight, int min_qnty, int max_qnty, int min_unitPrice, int max_unitPrice)
        {
            goodRule g = new goodRule(_name, _com, min_weight, max_weight, min_qnty,max_qnty, min_unitPrice, max_unitPrice);
            gcon.addToGoodsContainer(g);
        }
        public void confirmGoodContainer(int rulePK)
        {
            foreach (goodRule g in gcon.list)
            {
                _goodTable.insert_new_good(g.goodName, g.company, g.min_weight, g.max_weight,g.min_qnty, g.max_qnty, g.min_unitPrice, g.max_unitPrice, rulePK);
            }
        }
        public goodRuleContainer get_container()
        {
            return gcon;
        }

        public List<string> getGoodList()
        {
            int i = 0;
            List<string> items = new List<string>();
            foreach (goodRule g in gcon.list)
            {
                items.Add(g.goodName + "(" + i + ")");
                i++;
            }
            return items;
        }
        //
        public List<goodRule> getGoodlist_detail()
        {
            List<goodRule> goodL = new List<goodRule>();
            foreach (goodRule g in gcon.list)
            {
                goodL.Add(g);

            }
            return goodL;
        }
        public void removeGood(string s)
        {
            string[] sArr = s.Split('(');
            string goodstr = sArr[1].Substring(0, sArr[1].Length - 1);
            int goodnum = Convert.ToInt32(goodstr);
            gcon.list.RemoveAt(goodnum);
        }
 
    }
}
