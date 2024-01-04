internal class Program
{
    private static void Main(string[] args)
    {
        // 21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
 
            Console.WriteLine("Ghiceste un numar intre 1 si 1024.");
            GhicesteNumarul();
    }

    static void GhicesteNumarul()
        {
            Random rnd = new Random();
            int nrAles = rnd.Next(1, 1025);
            int numarGuess;

           do
           {
                Console.Write("Introduceti un numar: ");
                numarGuess = int.Parse(Console.ReadLine());

                if (numarGuess == nrAles)
                {
                    Console.WriteLine($"Felicitari! Ai ghicit numarul.");
                }
                else if (numarGuess < nrAles)
                {
                    Console.WriteLine("Numarul este mai mare sau egal.");
                }
                else
                {
                    Console.WriteLine("Numarul este mai mic.");
                }

           } while (numarGuess != nrAles);
    }
}
