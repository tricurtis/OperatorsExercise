using System;

namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For division, create two integer variables called a and b.

            int a = 17;
            int b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

        //define a method - which performs some functionality. that can 
        //be used over and over again 
        public static double AreaOfCircle(double radius)
        {

            //this is the scope of the method
            var area = Math.PI * Math.Pow(radius, 2);

            return area;


        }
    }
}
