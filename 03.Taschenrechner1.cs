using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _03.Taschenrechner1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wert1, wert2;
            int ergebnis = 0;
            char funktion;

            Console.WriteLine("Taschenrechner");
            Console.WriteLine("==============");
            Console.WriteLine();

            Console.WriteLine("Geben Sie bitte den ersten Wert ein: ");
            wert1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Geben Sie bitte die Funktion ein: ");
            funktion = Convert.ToChar(Console.ReadLine());


            Console.Write("Geben Sie bitte den zweiten Wert ein: ");
            wert2 = Convert.ToInt32(Console.ReadLine());

            if (funktion == '+') ergebnis = wert1 + wert2;
            if (funktion == '-') ergebnis = wert1 - wert2;
            if (funktion == '*') ergebnis = wert1 * wert2;
            if (funktion == '/') ergebnis = wert1 / wert2;

            Console.WriteLine();
            Console.WriteLine($"Das Ergebnis von {wert1} {funktion} {wert2} = {ergebnis}");

            Console.WriteLine();
            Console.WriteLine("Bitte beliebige Taste druecken");
            Console.ReadLine();
        }
    }
}
