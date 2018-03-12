using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalExtensions
{
    public static class FunctionalMath
    {
        public static Func<double, double> DivideBy(double a) => (b) => b / a;
        public static Func<float, float> DivideBy(float a) => b => b / a;
    }
}
