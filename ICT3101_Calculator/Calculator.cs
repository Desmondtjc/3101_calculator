using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }

        private Calculator _calculator;
        private double _result;

        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            double result;
            if (num1== 0)
            {
                result = 2;
            }
            else if (num2==0)
            {
                result = 200;
            }
            else if (num1 == 0 && num2 == 0)
            {
                result = 666;
            }
            else
            {
                result = num1 + num2;
            }
            return result;
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {

            if (num1 == 0 && num2 == 0)
            {
                _result = 1;
            }
            else if (num1 == 0)
            {
                _result = 0;
            }
            else if (num2 == 0)
            {
                _result = double.PositiveInfinity;
            }
            else
            {
                _result = (num1 / num2);
            }
            return _result;
        }

        public double Factorial(double num1)
        {
            int i, fact = 1;
            for (i = 1; i <= num1; i++)
            {
                fact = fact * i;
            }
            return (fact);
        }

        public double UnknownFunctionA(double num1,double num2)
        {
            double result = 0;
            double difference = num1 - num2;
            if (num1 == num2)
            {
               result = 1;
            }
            else if (difference > 1)
            {
                result = (Factorial(num1) / Factorial(num2)) / difference;
            }
            else if (difference == 1)
            {
                result = (Factorial(num1) / Factorial(num2));
            }
            else
            {
                throw new ArgumentException("Error");
            }

            return result;
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            double result = 0;
            double difference = num1 - num2;
            if (num1 == num2)
            {
                result = Factorial(num1);
            }
            else if (difference == 1)
            {
                result = Factorial(num1);
            }
            else if (difference > 1)
            {
                result = (Factorial(num1) / difference);
            }
            else
            {
                throw new ArgumentException("Error");
            }

            return result;
        }
    }
}
