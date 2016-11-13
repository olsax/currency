using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    class Program
    {
        static void Main(string[] args)
       {
        
            Init();
        }

        static void Init()
        {
            ICurrencyProvider provider = new CurrencyProvider();
            ICurrencyParser parser = new NBPCurrencyParser();
            IRepo repo = Repo.getInstance();

            List<Currency> list = parser.parse(provider.DowloadData());

            repo.fetchData(list);
        }
    }
}
