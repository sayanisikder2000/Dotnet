using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch07SayaniSikder
{
    class LinqToXml
    {
        public static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("D:\\Countries.xml");

            var Countries = from country in xdoc.Descendants("countries").Elements("country").Attributes("name")
                            select country.Value;

            foreach (var country in Countries)
            {
                Console.Write(country + " ");
            }
        }
    }
}
