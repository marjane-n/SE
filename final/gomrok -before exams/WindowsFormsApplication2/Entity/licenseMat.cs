using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomrok.Entity
{
    public class licenseMat
    {
        public int id;
        public int Lid;
        public string MName;
        public string Mcomp;
        public int MMinFee;
        public int MMaxFee;
        public int MMinWeight;
        public int MMaxWeight;
        public int MMinCount;
        public int MMaxCount;

        public licenseMat(int _Lid, string _MName, string _Mcomp, int _MMinFee, int _MMaxFee, int _MMinWeight, int _MMaxWeight, int _MMinCount, int _MMaxCount)
        {
            Lid = _Lid;
            MName = _MName;
            Mcomp = _Mcomp;
            MMinFee = _MMinFee;
            MMaxFee = _MMaxFee;
            MMinWeight = _MMinWeight;
            MMaxWeight = _MMaxWeight;
            MMinCount = _MMinCount;
            MMaxCount = _MMaxCount;
        }

        public licenseMat(int _id, int _Lid, string _MName, string _Mcomp, int _MMinFee, int _MMaxFee, int _MMinWeight, int _MMaxWeight, int _MMinCount, int _MMaxCount)
        {
            id = _id;
            Lid = _Lid;
            MName = _MName;
            Mcomp = _Mcomp;
            MMinFee = _MMinFee;
            MMaxFee = _MMaxFee;
            MMinWeight = _MMinWeight;
            MMaxWeight = _MMaxWeight;
            MMinCount = _MMinCount;
            MMaxCount = _MMaxCount;
        }
    }
}
