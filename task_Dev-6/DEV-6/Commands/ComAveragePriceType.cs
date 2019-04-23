using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class ComAveragePriceType : ICommand
    {
        /// <summary>
        /// Class contains execution method for "AveragePriceType" command 
        /// </summary>
        private Reciever reciever;
        private string type;

        public ComAveragePriceType(Reciever r) => reciever = r; 

        public string Execute() => reciever.AveragePriceType();
    }
}
