using System;

namespace DEV_6
{
    /// <summary>
    ///     This class is an entry point of this programm
    /// </summary>
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            try
            {
                var ParseCars = new XmlParser(args[0]);
                var cars = ParseCars.GetCars();
                //var ParseTrucks = new XmlParser(args[1]);
                //var trucks = ParseTrucks.GetCars();

                Invoker inv;
                var rCars = new Reciever(cars);
                //var rTrucks = new Reciever(trucks);

                Console.WriteLine("Choose type: " +
                                  "1) Cars" +
                                  "2) Trucks");
                Console.WriteLine("Your choice: ");
                var choice = Console.ReadLine();
                //if ("1" == choice)
                    inv = new Invoker(rCars);
               // else
                //    inv = new Invoker(rTrucks);

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