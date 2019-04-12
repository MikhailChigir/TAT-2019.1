using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_6
{
    /// <summary>
    ///     This class contains bodies of methods, used in commands
    ///     and also recieves array of cars, which we're going to work with
    /// </summary>
    internal class Reciever
    {
        private readonly List<Car> cars;

        /// <summary>
        ///     Constructor for getting array of cars.
        /// </summary>
        /// <param name="cars">
        ///     List parsed from xml doc
        /// </param>
        public Reciever(List<Car> cars)
        {
            this.cars = cars;
        }

        /// <summary>
        ///     Counts average price of all cars
        /// </summary>
        /// <returns>This price</returns>
        public string AveragePrice()
        {
            var price = from car in cars
                select car.Price;
            return price.Average().ToString();
        }

        /// <summary>
        ///     Counts average price of certain cars.
        ///     "Certain" means certain brand (type).
        /// </summary>
        /// <returns>This price</returns>
        public string AveragePriceType()
        {
            Console.WriteLine("Input brand: \n");
            var type = Console.ReadLine();
            var price = from car in cars
                where car.Type == type
                select car.Price;
            return price.Average().ToString();
        }

        /// <summary>
        ///     Counts quantity of all cars in array
        /// </summary>
        /// <returns>This quantity</returns>
        public string CountAll()
        {
            var counter = from car in cars
                select car.Quantity;
            return counter.ToString();
        }

        /// <summary>
        ///     Counts quantity of certain cars.
        ///     "Certain" still means the same.
        /// </summary>
        /// <returns>This quantity</returns>
        public string CountTypes()
        {
            Console.WriteLine("Input brand: \n");
            var type = Console.ReadLine();
            var counter = from car in cars
                where car.Type == type
                select car.Quantity;
            return counter.ToString();
        }
    }
}