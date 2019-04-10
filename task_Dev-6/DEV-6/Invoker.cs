using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class Invoker
    {
        private Dictionary<string, ICommand> _commands;

        /// <summary>
        /// Constructor has to arrange dictionary of commands
        /// </summary>
        /// <param name="r">Contains info about cars, necessary for commands </param>
        public Invoker(Reciever r)
        {
            _commands = new Dictionary<string, ICommand>();
            _commands.Add("1", new ComAveragePrice(r));
            _commands.Add("2", new ComAveragePriceType(r));
            _commands.Add("3", new ComCountAll(r));
            _commands.Add("4", new ComCountTypes(r));
        }

        /// <summary>
        /// Draws menu.
        /// </summary>
        public void DrawMenu()
        {
            Console.WriteLine("\n Choose operation: \n" + 
                              "1. Calculate average price of all cars\n"+
                              "2. Calculate average price of certain cars\n"+
                              "3. Count all cars\n"+
                              "4. Count certain cars\n");
        }
        
        /// <summary>
        /// Performs chosen operation 
        /// </summary>
        public void PerformAction()
        {
            Console.WriteLine("Your choice: ");
            var input = Console.ReadLine();

            if (_commands.ContainsKey(input))
            {
                var cmd = _commands[input];
                cmd.Execute();
            }
            
        }

    }
}
