using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace curr
{
    class NBPCurrencyParser : ICurrencyParser
    {
        public List<Currency> parse(string data)
        {
            List<Currency> result = new List<Currency>();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(data);

            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/tabela_kursow/pozycja");

            foreach(XmlNode node in nodeList)
            {
                Currency curr = new Currency();
                curr.Name = node.SelectSingleNode("nazwa_waluty").InnerText;
                curr.Predictor = int.Parse(node.SelectSingleNode("przelicznik").InnerText);
                curr.CurrencyCode = node.SelectSingleNode("kod_waluty").InnerText;
                curr.Value = double.Parse(node.SelectSingleNode("kurs_sredni").InnerText);
                result.Add(curr);
            }

            return result;
        }
    }
}
