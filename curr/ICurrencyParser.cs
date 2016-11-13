using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    public interface ICurrencyParser
    {
        List<Currency> parse(String data);
    }
}
