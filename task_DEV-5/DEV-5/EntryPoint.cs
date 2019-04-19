using System;
using System.Collections.Generic;

namespace DEV_5
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            var list = new List<IFlyable> {new Bird(), new Plane(), new SpaceShip()};

            foreach (var item in list)
            {
                item.FlyTo(new Point(100, 200, 800));
                Console.WriteLine($"{item.WhoAmI()}: {item.GetFlyTime()}");
            }
        }
    }
}