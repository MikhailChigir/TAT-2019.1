using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace DEV_6
{
    class XmlParser
    {
        private readonly  XDocument _xDoc;

        public XmlParser(String FileLink) => _xDoc = XDocument.Load(FileLink);

        public List<Car> GetCars()
        {
            var cars = new List<Car>();
            foreach (var element in _xDoc.Element("cars")?.Elements("car"))
            {
                var Model = element.Element("model").ToString();
                var Price = element.Element("price").ToString();
                var Quantity = element.Element("quantity").ToString();
                var Type = element.Element("type").ToString();

                var car = new Car(Type, Model, Price, Quantity);
                cars.Add(car);

            }

            return cars;

        }
        
    }
}
