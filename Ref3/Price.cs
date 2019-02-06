using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ref3
{
    public abstract class Price
    {
        public abstract double GetThisAmount(int daysRented);
        public abstract int GetFrequentRenterPoints(int daysRented);
    }

    public class PriceRegular : Price
    {
        public override double GetThisAmount(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
                result += (daysRented - 2) * 1.5;

            return result;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            int res = 1;

            return res;
        }
    }

    public class PriceNewRelease : Price
    {
        public override double GetThisAmount(int daysRented)
        {
            double result = daysRented * 3;

            return result;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            int res = 1;

            if (daysRented > 1)
                res++;

            return res;
        }
    }

    public class PriceChildrens : Price
    {
        public override double GetThisAmount(int daysRented)
        {
            double result = 1.5;

            if (daysRented > 3)
                result += (daysRented - 3) * 1.5;

            return result;
        }

        public override int GetFrequentRenterPoints(int daysRented)
        {
            int res = 1;

            return res;
        }
    }
}
