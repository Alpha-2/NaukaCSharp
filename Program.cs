using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nauka
{
    class Program
    {
        static void Main(string[] args)
        {
            double _userArgA;
            double _userArgB;
            try
            {
                Console.Write("enter the length of side A: ");
                _userArgA = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.Write("enter the length of side B: ");
                _userArgB = double.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine(RectangleAreaCalc(_userArgA, _userArgB));
                Console.WriteLine();
                Console.WriteLine("-----To exit, press any key-----");

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static double RectangleAreaCalc(double sideA, double sideB)
        {
            double result = 0;

            result = sideA * sideB;

            return result;
        }
    }
}
