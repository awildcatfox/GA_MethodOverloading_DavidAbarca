using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading_DavidAbarca
{
    internal class MathOperations
    {
        public int Add(int a, int b) //The first Add method takes two integer parameters and returns their sum as an integer
        {
            return a + b;
        }

        public double Add(double a, double b) //The second Add method takes two double parameters and returns their sum as a double.
        {
            return a + b;
        }

        public double Add(double a, double b, double c) //The third Add method takes two string parameters and concatenates them.
        {
            return a + b + c;
        }

        // subtract
        public int Subtract(int a, int b) //2 int
        {
            return a - b;   
        }

        public double Subtract(double a, double b) //2 double
        {
            return a - b;
        }

        public double Subtract(double a, double b, double c) //3 double
        {
            return a - b - c;
        }

        // multiply
        public int Multiply(int a, int b) //2 int
        {
            return a * b;
        }

        public double Multiply(double a, double b) //2 double
        {
            return a * b;
        }

        public double Multiply(double a, double b, double c) //3 double
        {
            return a * b * c;
        }

        // Divide
        public int Divide(int a, int b) //2 int
        {
            if (b != 0)
            {
                return a / b;// Your code
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

        public double Divide(double a, double b) //2 double
        {
            if (b != 0)
            {
                return a / b;// Your code
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }




    }
}
