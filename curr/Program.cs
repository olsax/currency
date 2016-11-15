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
            // Tworzymy obiekty reprezentujące poszczególne warstwy
            ICurrencyProvider provider = new CurrencyProvider();
            ICurrencyParser parser = new NBPCurrencyParser();
            IRepo repo = Repo.getInstance();
            ICurrencyConverter converter = new CurrencyConverter();
            ICurrencyView view = new CurrencyView();
            //dokonujemy inicjacji - pobieramy dane, parsujemy, zapisujemy
            String downloadedData = provider.DowloadData();
            List<Currency> currencyList = parser.parse(downloadedData);
            repo.fetchData(currencyList);

            //przyklad uzycia logiki
            //double wynik = converter.convertFromPLN(5, "EUR");
            //Console.WriteLine("5zł to " + wynik + " euro");
            //Console.ReadKey();
            view.display();
        }
    }
}
