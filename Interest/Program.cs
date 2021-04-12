using System;

namespace Interest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double presentValue;
            double futureValue;
            double rate;
            double years;


            //Input
            Console.Write("Please Enter Your Future Value $");
            futureValue = double.Parse(Console.ReadLine());

            Console.Write("Please Enter Annual Interest Rate ");
           rate = double.Parse(Console.ReadLine());

            Console.Write("Please Enter number of Years");
            years = double.Parse(Console.ReadLine());

          //Process
            presentValue = futureValue / Math.Pow(1 + rate, years);


            //Output
            Console.WriteLine("Present Value is " + "   " + presentValue);


            Console.ReadKey();
        }
    }
}
