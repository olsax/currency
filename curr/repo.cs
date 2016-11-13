using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    public class Repo : IRepo
    {
        private List<Currency> currencies;

        private static Repo repo;

        private Repo()
        {
            currencies = new List<Currency>();
        }

        public static Repo getInstance()
        {
            if (repo == null)
            {
                repo = new Repo();
            }

            return repo;
        }

        public void add(Currency item)
        {
            this.currencies.Add(item);
        }

        public Currency findByCode(String code)
        {
            foreach(Currency item in currencies)
            {
                if (item.CurrencyCode.Equals(code))
                {
                    return item;
                }
            }

            return null;
        }

        public void fetchData(List<Currency> currencies)
        {
            this.currencies = currencies;
        }

    }
}
