using System;
using System.Collections.Generic;

namespace NumericalMethods
{
    public struct PointSLAE
    {
        public PointSLAE(double X1, double X2, double X3, double X4)
        {
            this.X1 = X1;
            this.X2 = X2;
            this.X3 = X3;
            this.X4 = X4;
        }

        public double X1;
        public double X2;
        public double X3;
        public double X4;
    }

    public class MethodSLAEIterations
    {
        private double _epsilon = 0.001;
        private PointSLAE Point;

        public MethodSLAEIterations()
        {
            Point = new PointSLAE(1.42, 0.57, 0.68, 2.14);
        }

        public MethodSLAEIterations(double epsilon) : this()
        {
            _epsilon = epsilon;
        }

        public List<PointSLAE> Calculate()
        {
            var result = new List<PointSLAE>();

            double x1 = 0.24 * Point.X1 + 0.21 * Point.X2 + 0.06 * Point.X3 - 0.34 * Point.X4 + 1.42;
            double x2 = 0.05 * Point.X1 + 0.32 * Point.X2 + 0.12 * Point.X4 - 0.57;
            double x3 = 0.35 * Point.X1 - 0.27 * Point.X2 - 0.05 * Point.X4 + 0.68;
            double x4 = 0.12 * Point.X1 - 0.43 * Point.X2 + 0.34 * Point.X3 - 0.21 * Point.X4 - 2.14;

            while (
                (Math.Abs(x1 - Point.X1) > _epsilon)
                || (Math.Abs(x2 - Point.X2) > _epsilon)
                || (Math.Abs(x3 - Point.X3) > _epsilon)
                || (Math.Abs(x4 - Point.X4) > _epsilon)
                )
            {
                result.Add(Point);
                Point = new PointSLAE(x1, x2, x3, x4);

                x1 = 0.24 * Point.X1 + 0.21 * Point.X2 + 0.06 * Point.X3 - 0.34 * Point.X4 + 1.42;
                x2 = 0.05 * Point.X1 + 0.32 * Point.X2 + 0.12 * Point.X4 - 0.57;
                x3 = 0.35 * Point.X1 - 0.27 * Point.X2 - 0.05 * Point.X4 + 0.68;
                x4 = 0.12 * Point.X1 - 0.43 * Point.X2 + 0.34 * Point.X3 - 0.21 * Point.X4 - 2.14;
            }

            return result;
        }
    }
}
