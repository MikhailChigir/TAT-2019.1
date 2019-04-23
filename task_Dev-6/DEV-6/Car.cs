﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    ///<summary>
    /// This class stores data from xml document
    /// </summary>

    class Car
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }

        public Car(string type, string model, string price, string quantity)
        {
            this.Type = type;
            this.Model = model;
            this.Price = int.Parse(price);
            this.Quantity = int.Parse(quantity);
        }
    }
}

