using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_3
{
    class Optimise
    {
        protected int CommonSalary;
        protected int CommonPerformance;
        protected int CertainDevsAmount;
        protected int CriterionNumb;
        protected DevLead lead = new DevLead();
        protected DevSinior sin = new DevSinior();
        protected DevMid mid = new DevMid();
        protected DevJun jun = new DevJun();
        public Dictionary<int, string> Developers = new Dictionary<int, string>(4);
        public Optimise()
        {
            CommonSalary = 0;
            CommonPerformance = 0;
            CertainDevsAmount = 0;
            CriterionNumb = 1;

        }

    }
}
