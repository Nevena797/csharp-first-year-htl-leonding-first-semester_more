using System;

namespace _03.Taschenrechner
{
    internal class Taschenrechner
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;

            if (symbol == "+")
            {
                result = numberOne + numberTwo;
            }
            else if (symbol == "-")
            {
                result = numberOne - numberTwo; 
            }
            else if (symbol == "*")
            {
                result = numberOne * numberTwo; 
            }
            else if (symbol == "/")
            {
                if (numberTwo != 0)
                {
                    result = numberOne / numberTwo;
                }
                else
                {
                    Console.WriteLine("Division durch 0 ist nicht möglich"); 
                    return; 
                }
            }
            else
            {
                Console.WriteLine("Bitte geben Sie ein gültiges Symbol ein"); 
                return; 
            }
            Console.WriteLine(result); 
    }
}
