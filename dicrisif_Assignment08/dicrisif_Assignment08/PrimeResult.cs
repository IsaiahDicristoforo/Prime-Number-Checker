using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace dicrisif_Assignment08
{

    class PrimeResult : IComparable
    {


        private BigInteger numberChecked;
        private bool isPrime;

        public PrimeResult(BigInteger numberChecked, bool isPrime)
        {
            this.numberChecked = numberChecked;
            this.isPrime = isPrime;


        } 
    

        public BigInteger Number
        {
            get
            {
                return numberChecked;
            }
        }

        public bool IsPrime
        {
            get
            {
            return isPrime;

            }
        }

        public override string ToString()
        {
            return numberChecked + (isPrime ? "   PRIME  " : "   NOT PRIME  ");
        }

        public static int ComparePrimeResults(PrimeResult result1, PrimeResult result2)
        {

            if(result1.Number > result2.numberChecked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int CompareTo(object obj)
        {
            PrimeResult result = (PrimeResult)obj;

            if (this.Number > result.Number)
            {
                return 1;
            }
            if (this.Number < result.Number)
            {
                return -1;
            }
            return 0;
        }
    }
}
