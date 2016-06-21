using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gomrok.Entity;
using gomrok.DB;

namespace gomrok.ctrller
{
    public class ctrldata
    {
        public event EventHandler AcceptedChanges;
        protected virtual void OnAcceptedChanges()
        {
            if ((this.AcceptedChanges != null))
            {
                this.AcceptedChanges(this, EventArgs.Empty);
            }
        }

        public void AcceptChanges()
        {
            this.OnAcceptedChanges();
        }

        public licenseMatsCtrl lmctrl { get; set; }
        
    }
}
