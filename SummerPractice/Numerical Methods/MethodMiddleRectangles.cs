﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalMethods
{
    public class MethodMiddleRectangles
    {     
        private double _a;
        private double _b;

        public MethodMiddleRectangles()
        {
            _a = 0.8;
            _b = 1.6;
        }

        public MethodMiddleRectangles(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double CalcIntegral(int n)
        {
            double result = 0;
            double h = (_b - _a) / n; ; // n = 100;

            for (int i = 0; i < n; i++)
            {
                result += InFunction(_a + h * (i + 0.5));
            }

            result *= h;
            return result;
        }
        private double InFunction(double x)
        { 
            return (Math.Pow(x, 2) + 1) * Math.Sin(x - 0.5);
        }
    }
}