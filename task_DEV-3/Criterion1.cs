using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Criterion1: Optimise
    {  
        public Criterion1(int sal)
        {
            CommonSalary = sal;
        }

        private int remainLead;
        private int remainSin;
        private int remainMid;
        private int remainJun;

        public int Calculate1()
        {
            remainLead = CommonSalary % lead.GetSalary();
            CertainDevsAmount = CommonSalary / lead.GetSalary();
            Developers.Add(CertainDevsAmount, "Leads");
            CommonPerformance = CertainDevsAmount * lead.GetPerformance();
            if (remainLead == 0)
            {
                return CommonPerformance;
            }

            remainSin = remainLead % sin.GetSalary();
            CertainDevsAmount = remainLead / sin.GetSalary();
            Developers.Add(CertainDevsAmount, "Siniors");
            CommonPerformance += CertainDevsAmount * sin.GetPerformance(); 
            if (remainSin == 0)
            {
                return CommonPerformance;
            }

            remainMid = remainSin % mid.GetSalary();
            CertainDevsAmount = remainSin / mid.GetSalary();
            Developers.Add(CertainDevsAmount, "Middles");
            CommonPerformance += CertainDevsAmount * mid.GetPerformance();
            if (remainMid == 0)
            {
                return CommonPerformance;
            }

           // remainJun = remainMid % jun.GetSalary();
            CertainDevsAmount = remainMid / jun.GetSalary();
            Developers.Add(CertainDevsAmount, "Juniors");
            CommonPerformance += CertainDevsAmount * jun.GetPerformance();
            
            return CommonPerformance;
            


        }
    }
}
