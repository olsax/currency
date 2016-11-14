using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curr
{
    public class Currency
    {
        private string name;
        private int predictor;
        private string currencyCode;
        private double value;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Predictor
        {
            get
            {
                return predictor;
            }

            set
            {
                predictor = value;
            }
        }

        public string CurrencyCode
        {
            get
            {
                return currencyCode;
            }

            set
            {
                currencyCode = value;
            }
        }

        public double Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
