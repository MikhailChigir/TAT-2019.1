using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_4
{
    class Seminar : Materials
    {
     
        public string Tasks { get; set;}
        public string Questions { get; set; }
        public string Answers { get; set; }

        public Seminar(int index, string description)
        {
            this.index = index;
            this.description = description;
        }
        


    }
}
