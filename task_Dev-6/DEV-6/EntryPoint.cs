using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DEV_6
{
    /// <summary>
    /// This class is an entry point of this programm
    /// </summary>
    class EntryPoint
    {

        static void Main(string[] args)
        {
            try
            {
                Car[] cars = new Car[10];             //Has to be loaded from xml file
                Reciever r = new Reciever(cars);
                Invoker inv = new Invoker(r);

                inv.DrawMenu();
                inv.PerformAction();



            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
