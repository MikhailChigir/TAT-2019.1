using System;
using System.Collections.Generic;

namespace DEV_6
{
    internal class Invoker
    {
        private readonly Dictionary<string, ICommand> _commands;

        /// <summary>
        ///     Constructor has to arrange dictionary of commands
        /// </summary>
        /// <param name="rCars">Contains info about cars, necessary for commands </param>
        public Invoker(Reciever rCars)
        {
            _commands = new Dictionary<string, ICommand>();
            _commands.Add("1", new ComAveragePrice(rCars));
            _commands.Add("2", new ComAveragePriceType(rCars));
            _commands.Add("3", new ComCountAll(rCars));
            _commands.Add("4", new ComCountTypes(rCars));
        }

        /// <summary>
        ///     Draws menu.
        /// </summary>
        public void DrawMenu()
        {
            Console.WriteLine("\n Choose operation: \n" +
                              "1. Calculate average price of all cars\n" +
                              "2. Calculate average price of certain cars\n" +
                              "3. Count all cars\n" +
                              "4. Count certain cars\n");
        }

        /// <summary>
        ///     Performs chosen operation
        /// </summary>
        public void PerformAction()
        {
            Console.WriteLine("Your choice: ");
            var input = Console.ReadLine();

            if (_commands.ContainsKey(input))
            {
                var cmd = _commands[input];
                Console.WriteLine(cmd.Execute());
            }
        }
    }
}