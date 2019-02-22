using System;

namespace BankTest
{
    public static class DoubleMath
    {
        public static bool GreaterThanOrEqualTo(this double startingNumber, double compareTo)
        {
            return startingNumber.GreaterThan(compareTo) || startingNumber.EqualTo(compareTo);
        }
        public static bool LessThanOrEqualTo(this double startingNumber, double compareTo)
        {
            return startingNumber.LessThan(compareTo) || startingNumber.EqualTo(compareTo);
        }
        public static bool GreaterThan(this double startingNumber, double compareTo)
        {
            return (startingNumber - compareTo) > .01;
        }
        public static bool LessThan(this double startingNumber, double compareTo)
        {
            return (compareTo - startingNumber) > .01;
        }
        public static bool EqualTo(this double startingNumber, double compareTo)
        {
            return Math.Abs(startingNumber - compareTo) < .00001;
        }
    }
}
