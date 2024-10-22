using System;

namespace MathLib
{
    public class ArithmeticProgression
    {
        private double firstTerm;
        private double commonDifference;

        public ArithmeticProgression(double firstTerm, double commonDifference)
        {
            this.firstTerm = firstTerm;
            this.commonDifference = commonDifference;
        }

        public double this[int index]
        {
            get
            {
                return firstTerm + (index - 1) * commonDifference;
            }
        }

        public double Sum(int n)
        {
            return (n / 2.0) * (2 * firstTerm + (n - 1) * commonDifference);
        }
    }
}
