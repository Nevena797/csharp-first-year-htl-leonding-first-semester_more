namespace _04.BSP06größteZahl1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0, numberTwo = 0, numberThree = 0, bigestNumber = 0;

            Console.Write("Geben Sie bitte den 1. Wert ein: ");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie bitte den 2. Wert ein: ");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geben Sie bitte den 3. Wert ein: ");
            numberThree = Convert.ToInt32(Console.ReadLine());

            if (numberOne < numberTwo)
            {
                if (numberTwo < numberThree)
                {
                    bigestNumber = numberThree;
                }
                else
                {
                    bigestNumber = numberTwo;
                }
            }
            else 
            {
                bigestNumber = numberOne;
            }

            Console.WriteLine($"Größte Zahl ist: {bigestNumber}");
        }
    }
}
