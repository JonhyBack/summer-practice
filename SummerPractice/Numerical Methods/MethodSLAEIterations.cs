using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods
{
    public class MethodSLAEIterations
    {
        private double _epsilon;
        public double X1 { get; set; } = 1.42;
        public double X2 { get; set; } = -0.57;
        public double X3 { get; set; } = 0.68;
        public double X4 { get; set; } = -2.14;


        public MethodSLAEIterations()
        {
            _epsilon = 0.001;
        }

        public MethodSLAEIterations(double epsilon)
        {
            _epsilon = epsilon;
        }

        public void InFunction()
        {
            double x1 = 0.24 * X1 + 0.21 * X2 + 0.06 * X3 - 0.34 * X4 + 1.42;
            double x2 = 0.05 * X1 + 0.32 * X3 + 0.12 * X4 - 0.57;
            double x3 = 0.35 * X1 - 0.27 * X2 - 0.05 * X4 + 0.68;
            double x4 = 0.12 * X1 - 0.43 * X2 + 0.34 * X3 - 0.21 * X4 - 2.14;

            if (
                (Math.Abs(x1 -X1) > _epsilon)
                || (Math.Abs(x2 - X2) > _epsilon)
                || (Math.Abs(x3 - X3) > _epsilon)
                || (Math.Abs(x4 - X4) > _epsilon)
                )
            {
                X1 = x1;
                X2 = x2;
                X3 = x3;
                X4 = x4;

                InFunction();
            } 
            else
            {
                X1 = x1;
                X2 = x2;
                X3 = x3;
                X4 = x4;
            }
        }   
    }
}
