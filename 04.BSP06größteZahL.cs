using System;

namespace _04.BSP06größteZahL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;
            int bigestNumber = 0;

            Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die dritte Zahl ein:");
            numberThree = Convert.ToInt32(Console.ReadLine());

            if ((numberOne > numberTwo) && (numberOne > numberThree))
            {
                bigestNumber = numberOne;
            }
            else if ((numberTwo > numberOne) && (numberTwo > numberThree))
            {
                bigestNumber = numberTwo;
            }
            else
            {
                bigestNumber = numberThree;
            }

            Console.WriteLine($"Die größte Zahl ist: {bigestNumber}");
        }
    }
}

