using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gomrok.DB;
namespace gomrok.ctrller
{
    class goodCtrl
    {
        database db = database.getDataBase();
        decgoodTable _goodTable = decgoodTable.get_good_table();
        goodContainer gcon = new goodContainer();
        
        public void add_good(string _name, string _com, int _weight, int _qnty, int _unitPrice)
        {
            good g = new good(_name, _com, _weight, _qnty, _unitPrice);
            gcon.addToGoodsContainer(g);
        }
        public void confirmGoodContainer(int decPK)
        {
            foreach(good g in gcon.list)
            {
                _goodTable.insert_new_good(g.goodName, g.company, g.weight, g.qnty, g.unitPrice, decPK);
            }
        }
        public goodContainer get_container()
        {
            return gcon;
        }

        public List<string> getGoodList()
        {
            int i = 0;
            List<string> items = new List<string>();
            foreach (good g in gcon.list)
            {
                    items.Add(g.goodName + "(" + i + ")");
                    i++;
            }
            return items;
        }
        public List<good> getGoodlist_detail()
        {
            List<good> goodL = new List<good>();
            foreach (good g in gcon.list)
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
