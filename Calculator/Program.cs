using System;
using System.Transactions;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {


            Calculator calc = new Calculator();

            Console.WriteLine("********* Adding *********");
            //Testing integers
            Console.Write("Adding 5 and 6 = ");
            Console.WriteLine(calc.Add(5, 6)); //Expecting 11

            //Testing decimal numbers
            Console.Write("Adding 5.1 and 6.5 = ");
            Console.WriteLine(calc.Add(5.1, 6.5)); //Expecting 11,6

            //Testing multiple decimals
            Console.Write("Adding 5.1234 and 6.1234 = ");
            Console.WriteLine(calc.Add(5.1234, 6.1234) + "\n"); //Expecting 11,2468

            Console.WriteLine("********* Subtracting *********");
            //Testing integers
            Console.Write("Subtracting 10 from 31 = ");
            Console.WriteLine(calc.Subtract(31, 10));

            //Testing decimal numbers
            Console.Write("Subtracting 10.2 from 31.5 = ");
            Console.WriteLine(calc.Subtract(31.5, 10.2));

            //Testing multiple decimals
            Console.Write("Subtracting 10.4321 from 31.1234 = ");
            Console.WriteLine(calc.Subtract(31.1234, 10.4321) + "\n");

            Console.WriteLine("********* Multiplying *********");
            //Testing integers
            Console.Write("Multiplying 3 with 6 = ");
            Console.WriteLine(calc.Multiply(3, 6));

            //Testing decimal numbers
            Console.Write("Multiplying 3.5 with 6.9 = ");
            Console.WriteLine(calc.Multiply(3.5, 6.9));

            //Testing multiple decimals
            Console.Write("Multiplying 3.1234 with 6.1234 = ");
            Console.WriteLine(calc.Multiply(3.1234, 6.1234) + "\n");

            Console.WriteLine("********* Power of *********");
            //Testing integers
            Console.Write("Taking 2 raised to the power of 3 = ");
            Console.WriteLine(calc.Power(2, 3));

            //Testing decimal numbers
            Console.Write("Taking 2.2 raised to the power of 3.1 = ");
            Console.WriteLine(calc.Power(2.2, 3.1));

            //Testing multiple decimals
            Console.Write("Taking 2.1234 raised to the power of 3.1234 = ");
            Console.WriteLine(calc.Power(2.1234, 3.1234));

        }
    }

    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public double Add(double addend)
        {
            Accumulator += addend;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator -= subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator *= multiplier;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            Accumulator /= divisor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Accumulator { get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
