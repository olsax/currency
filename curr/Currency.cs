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
                return CurrencyCode1;
            }

            set
            {
                CurrencyCode1 = value;
            }
        }

        public double Value
        {
            get
            {
                return Value1;
            }

            set
            {
                this.Value1 = value;
            }
        }

        public string CurrencyCode1
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

        public double Value1
        {
            get
            {
                return Value2;
            }

            set
            {
                this.Value2 = value;
            }
        }

        public double Value2
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
