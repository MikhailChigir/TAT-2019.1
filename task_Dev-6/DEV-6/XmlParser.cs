using System.Collections.Generic;
using System.Xml.Linq;

namespace DEV_6
{
    internal class XmlParser
    {
        private readonly XDocument _xDoc;

        public XmlParser(string FileLink)
        {
            _xDoc = XDocument.Load(FileLink);
        }

        public List<Car> GetCars()
        {
            var cars = new List<Car>();
            foreach (var element in _xDoc.Element("cars")?.Elements("car"))
            {
                var Model = element.Element("model").Value;
                var Price = element.Element("price").Value;
                var Quantity = element.Element("quantity").Value;
                var Type = element.Element("type").Value;

                var car = new Car(Type, Model, Price, Quantity);
                cars.Add(car);
            }

            return cars;
        }
    }
}