using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace gomrok
{
    class goodContainer
    {
       public List<good> list = new List<good>();
       private int itemnum = 0;
       public void addToGoodsContainer(good g)
       {
           list.Add(g);
       }
       public List<good> goodList()
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
