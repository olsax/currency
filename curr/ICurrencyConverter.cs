using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    interface ICurrencyConverter
    {
        double convertToPLN(double amount, string code);
        double convertFromPLN(double amount, string code);
        double convertExtended(double amount, string codeIn, string codeOut);
    }
}
