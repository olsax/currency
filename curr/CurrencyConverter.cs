using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    class CurrencyConverter:ICurrencyConverter
    {
        public double convertToPLN(double amount, string code)
        {
            IRepo repo = Repo.getInstance();
            double value = repo.findByCode(code).Value;
            double predictor = repo.findByCode(code).Predictor;
            double result = (amount / predictor) * value;
            return result;
        }

        public double convertFromPLN(double amount, string code)
        {
            IRepo repo = Repo.getInstance();
            double value = repo.findByCode(code).Value;
            double predictor = repo.findByCode(code).Predictor;
            double result = (amount * predictor) / value;
            return result;
        }

        public double convertExtended(double amount, string codeIn, string codeOut)
        {
            if (codeIn.Equals("PLN"))
            {
                return convertFromPLN(amount, codeOut);
            }
            if (codeOut.Equals("PLN"))
            {
                return convertToPLN(amount, codeIn);
            }
            
            double value1 = convertToPLN(amount, codeIn);
            double value2 = convertFromPLN(value1, codeOut);
            return value2;
        }
    }
}
