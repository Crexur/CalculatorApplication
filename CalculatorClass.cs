using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Information<T>(T argl);

    internal class CalculatorClass
    {
        public Information<double> info;

        public event Action CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                // Add event handler logic here
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
                // Remove event handler logic here
            }
        }

        public double GetSum(double a, double b)
        {
            return a + b;
        }

        public double GetDifference(double a, double b)
        {
            return a - b;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");

            }
        }
    }
}
