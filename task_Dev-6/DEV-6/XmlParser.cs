using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DEV_6
{
    class XmlParser
    {
        private string root;

        public XmlParser(string root) => this.root = root;

        XmlDocument XDoc = new XmlDocument();
    }
}
