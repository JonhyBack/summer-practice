using System;

namespace NumericalMethods
{
    public class MethodSplineInterPolinom
    {
        private double[] arrX = new double[6] { -6.5, -4.5, -2.5, -0.5, 1.5, 3.5 };
        private double[] arrY = new double[6] { 130, 94, 66, 46, 38, 38 };
        private double[] arrM = new double[6] { -20, -18, -14, -10, -4, 0 };
        private double h = 2;

        public double[] ArrayX { get => arrX; }

        public double[] Calculate()
        {
            double[] y = new double[5];

            for (int i = 1; i <= y.Length; i++)
            {
                y[i-1] = InFunction(arrX[i-1], i);               
            }

            return y;
        }

        public double InFunction(double x, int i)
        {
                   double result = (arrM[i - 1] * (Math.Pow(arrX[i] - x, 2) * (x - arrX[i - 1]) / Math.Pow(h, 2)))
                    + (arrM[i] * (Math.Pow(x - arrX[i - 1], 2) * (x - arrX[i]) / Math.Pow(h, 2)))
                    + (arrY[i - 1] * ((Math.Pow(arrX[i] - x, 2) * (2 * (x - arrX[i - 1]) + h)) / Math.Pow(h, 3)))
                    + (arrY[i] * ((Math.Pow(x - arrX[i - 1], 2) * (2 * (arrX[i] - x) + h)) / Math.Pow(h, 3)));
            
            return result;
        }
    }
}
