using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    /// <summary>
    /// Class contains execution method for "CountTypes" command 
    /// </summary>
    class ComCountTypes : ICommand
    {
        private Reciever reciever;

        public ComCountTypes(Reciever r) => reciever = r;

        public string Execute() => reciever.CountTypes();
    }
}
