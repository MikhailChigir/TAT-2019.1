using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    /// <summary>
    /// Class contains execution method for "AveragePrice" command
    /// </summary>
    class ComAveragePrice : ICommand
    {
        private Reciever reciever;

        public ComAveragePrice(Reciever r) => reciever = r;

        public string Execute() => reciever.AveragePrice();
    }
}
