using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        // shall return the sum of a + b
        public double add(double a, double b)
        {
            return a + b;
        }

        // shall return the difference of a and b, a - b
        public double subtract(double a, double b)
        {
            return a - b;
        }

        // shall return the product of a and b, a * b
        public double multiply(double a, double b)
        {
            return a * b;
        }

        // shall return x raised to the expth power, x^exp
        public double power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

    }
}
