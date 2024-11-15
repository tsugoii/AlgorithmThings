using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _451_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double evaluate(double[] coefficients, double x)
            {
                double result = coefficients[0]; double power = 1;
                for (int i = 1; i < coefficients.length; i++)
                {
                    power = power * x;
                    result = result + coefficients[i] * power;
                }
                return result;
            }
        }
    }
}