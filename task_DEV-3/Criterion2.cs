using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Criterion2: Optimise
    {
        public Criterion2(int perf)
        {
            CommonPerformance = perf;
        }

        private int remainLead;
        private int remainSin;
        private int remainMid;
        private int remainJun;

        public int Calculate2()
        {
            remainLead = CommonPerformance % lead.GetPerformance();
            CertainDevsAmount = CommonPerformance / lead.GetPerformance();
            Developers.Add(CertainDevsAmount, "Leads");
            CommonSalary = CertainDevsAmount * lead.GetSalary();
            if (remainLead == 0)
            {
                return CommonSalary;
            }

            remainSin = remainLead % sin.GetPerformance();
            CertainDevsAmount = remainLead / sin.GetPerformance();
            Developers.Add(CertainDevsAmount, "Siniors");
            CommonSalary += CertainDevsAmount * sin.GetSalary();
            if (remainSin == 0)
            {
                return CommonSalary;
            }

            remainMid = remainSin % mid.GetPerformance();
            CertainDevsAmount = remainSin / mid.GetPerformance();
            Developers.Add(CertainDevsAmount, "Middles");
            CommonSalary += CertainDevsAmount * mid.GetSalary();
            if (remainMid == 0)
            {
                return CommonSalary;
            }

            CertainDevsAmount = remainMid / jun.GetPerformance();
            Developers.Add(CertainDevsAmount, "Juniors");
            CommonSalary += CertainDevsAmount * jun.GetSalary();
            return CommonSalary;
        }
    }
}
