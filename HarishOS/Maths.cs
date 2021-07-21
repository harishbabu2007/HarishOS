// Made by harish
// Math Commands Functions



using System;
using System.Collections.Generic;
using System.Text;

namespace HarishOS
{
    class Maths
    {
        // Addition
        public void Add()
        {
            try
            {
                string ni1, ni2;
                Console.Write("first number : ");
                ni1 = Console.ReadLine();
                Console.Write("second number : ");
                ni2 = Console.ReadLine();

                double n1, n2, res;
                n1 = double.Parse(ni1);
                n2 = double.Parse(ni2);
                res = n1 + n2;

                Console.WriteLine(res.ToString());
            }
            catch
            {
                Console.WriteLine("please enter correct values");
            }
        }

        // Subtraction
        public void Sub()
        {
            try
            {
                string ni1, ni2;
                Console.Write("first number : ");
                ni1 = Console.ReadLine();
                Console.Write("second number : ");
                ni2 = Console.ReadLine();

                double n1, n2, res;
                n1 = double.Parse(ni1);
                n2 = double.Parse(ni2); ;
                res = n1 - n2;

                Console.WriteLine(res.ToString());
            }
            catch
            {
                Console.WriteLine("please enter correct values");
            }
        }

        // Multiplication
        public void Mul()
        {
            try
            {
                string ni1, ni2;
                Console.Write("first number : ");
                ni1 = Console.ReadLine();
                Console.Write("second number : ");
                ni2 = Console.ReadLine();

                double n1, n2, res;
                n1 = double.Parse(ni1);
                n2 = double.Parse(ni2);
                res = n1 * n2;

                Console.WriteLine(res.ToString());
            }
            catch
            {
                Console.WriteLine("please enter correct values");
            }
        }

        // Division
        public void Div()
        {
            try
            {
                string ni1, ni2;
                Console.Write("first number : ");
                ni1 = Console.ReadLine();
                Console.Write("second number : ");
                ni2 = Console.ReadLine();

                double n1, n2, res;
                n1 = double.Parse(ni1);
                n2 = double.Parse(ni2);
                res = n1 / n2;

                Console.WriteLine(res.ToString());
            }
            catch
            {
                Console.WriteLine("please enter correct values");
            }
        }
    }
}
