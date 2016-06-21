using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gomrok.Entity;

namespace gomrok.Entity
{
    class goodRuleContainer
    {
        public List<goodRule> list = new List<goodRule>();
        private int itemnum = 0;
        public void addToGoodsContainer(goodRule g)
        {
            list.Add(g);
        }
        public List<goodRule> goodList()
        {
            return list;
        }
        public void removeFromGoodsContainer(int _goodPrimaryKey)
        {
            var itemToRemove = list.SingleOrDefault(r => r.primaryKey == _goodPrimaryKey);
            if (itemToRemove != null)
            {
                list.Remove(itemToRemove);
            }
        }
    }
}
