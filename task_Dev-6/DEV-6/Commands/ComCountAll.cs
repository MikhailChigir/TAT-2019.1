using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    /// <summary>
    /// Class contains execution method for "CountAll" command 
    /// </summary>
    class ComCountAll : ICommand
    {
        private Reciever reciever;

        public ComCountAll(Reciever r) => reciever = r;

        public string Execute() => reciever.CountAll();
    }
}
