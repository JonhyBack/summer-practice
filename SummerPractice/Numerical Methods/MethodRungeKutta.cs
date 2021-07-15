using System;
using System.Collections.Generic;

namespace NumericalMethods
{
    public struct CalculationsRungeKutta
    {
        public double A1;
        public double A2;
        public double A3;
        public double A4;
        public double A;
        public double X;
        public double Y;
    }

    public class MethodRungeKutta
    {
        private (double Begin, double End) limit = (1.8, 2.8);
        private double h = 0.02;

        public List<CalculationsRungeKutta> Calculate()
        {
            var result = new List<CalculationsRungeKutta>();
            var currIter = new CalculationsRungeKutta();

            currIter.Y = 0.5;
            for (double i = limit.Begin; i < limit.End; i+=h)
            {
                currIter.X = i;
                currIter.A1 = InFunction(currIter.X, currIter.Y);
                currIter.A2 = InFunction(currIter.X + h / 2, currIter.Y + (currIter.A1 * h / 2));
                currIter.A3 = InFunction(currIter.X + h / 2, currIter.Y + (currIter.A2 * h / 2));
                currIter.A4 = InFunction(currIter.X + h, currIter.Y + (currIter.A3 * h));
                currIter.A = (currIter.A1 + (2 * currIter.A2) + (2 * currIter.A3) + currIter.A4) / 6;

                result.Add(currIter);

                var nextIter = new CalculationsRungeKutta();
                nextIter.Y = currIter.Y + currIter.A * h;
                currIter = nextIter;
            }

            return result;
        }

        private double InFunction(double x, double y)
        {
            return x + Math.Pow(y, 2);
        }

    }
}
