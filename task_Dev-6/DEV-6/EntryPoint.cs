using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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
                XmlParser XmlParser = new XmlParser(args[0]);
                var cars = XmlParser.GetCars();

                foreach (var c in cars)
                {
                    Console.WriteLine(c.Price);
                    Console.WriteLine(c.Model);
                }

                Reciever r = new Reciever(cars);
                Invoker inv = new Invoker(r);

                inv.DrawMenu();
                inv.PerformAction();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
