using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Criterion3 : Optimise
    {
        public Criterion3(int perf)
        {
            CommonPerformance = perf;
        }

        private int remainLead;
        private int remainSin;
        private int remainMid;
        private int remainJun;

        public Dictionary<int, string> Calculate3()
        {
            remainLead = CommonPerformance % lead.GetPerformance();
            CertainDevsAmount = CommonPerformance / lead.GetPerformance();
            Developers.Add(CertainDevsAmount, "Leads");
            if (remainLead == 0)
            {
                return Developers;
            }

            remainSin = remainLead % sin.GetPerformance();
            CertainDevsAmount = remainLead / sin.GetPerformance();
            Developers.Add(CertainDevsAmount, "Siniors");
            if (remainSin == 0)
            {
                return Developers;
            }

            //remainMid = remainSin % mid.GetPerformance();
            CertainDevsAmount = remainSin / mid.GetPerformance();
            Developers.Add(CertainDevsAmount, "Middles");

            return Developers;

        }
    }
}
