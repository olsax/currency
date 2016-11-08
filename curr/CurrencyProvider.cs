using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    class CurrencyProvider:ICurrencyProvider
    {
        public string DowloadData()
        {
            string url = "http://www.nbp.pl/kursy/xml/lastA.xml";
            string xml;
            using (var webClient = new WebClient())
            {
                xml = webClient.DownloadString(url);

            }
            return xml;
        }
    }
}
