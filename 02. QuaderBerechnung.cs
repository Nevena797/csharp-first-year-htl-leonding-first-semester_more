namespace _02._QuaderBerechnung
{
    internal class Program
    {
        class MainClass
        {
            public static void Main(string[] args)
            {
                int laenge, breite, hoehe, grundflaeche, mantel, oberflaeche, volumen;
                string einheit;


                Console.WriteLine("Eingabewerte des Quarders");
                Console.WriteLine("========================");
                Console.WriteLine();

                Console.Write("Geben Sie bitte die Länge ein:  ");
                laenge = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie bitte die Breite ein: ");
                breite = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie bitte die Höhe ein:  ");
                hoehe = Convert.ToInt32(Console.ReadLine());

                Console.Write("Geben Sie bitte die MASS-Einheit ein: ");
                einheit = Console.ReadLine();

                grundflaeche = breite * laenge;
                mantel = 2 * (laenge + breite) * hoehe;
                oberflaeche = 2 * grundflaeche + mantel;
                volumen = laenge * breite * hoehe;

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Kenngrößen des Quarders");
                Console.WriteLine("========================");
                Console.WriteLine();

                Console.WriteLine("Die Grundfläche ist: " + grundflaeche + einheit + "2");
                Console.WriteLine("Der Mantel ist ist:  " + mantel + einheit + "2");
                Console.WriteLine("Die Oberflaeche ist: " + oberflaeche + einheit + "2");
                Console.WriteLine("Das Volumen ist:     " + volumen + einheit + "2");
                Console.WriteLine();


                Console.WriteLine();
                Console.WriteLine("Bitte beliebige Taste drücken");
                Console.ReadLine();


            }
        }
    }
}
    