using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    public interface IRepo
    {
        void fetchData(List<Currency> list);
        Currency findByCode(String currencyCode);
    }
}
