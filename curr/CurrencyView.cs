using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    class CurrencyView : ICurrencyView
    {
        public void display()
        {
            ICurrencyConverter converter = new CurrencyConverter();
            Console.WriteLine("Podaj walutę z której chcesz przeliczyć pieniądze: ");
            string codeIn = Console.ReadLine();
            Console.WriteLine("Podaj walutę na którą chcesz przeliczyć pieniądze: ");
            string codeOut = Console.ReadLine();
            Console.WriteLine("Podaj kwotę: ");
            double amount = double.Parse(Console.ReadLine());


            Console.WriteLine(amount + " " + codeIn + " to " + converter.convertExtended(amount, codeIn, codeOut) + " " + codeOut);
            Console.ReadKey();
        }

    }
}
