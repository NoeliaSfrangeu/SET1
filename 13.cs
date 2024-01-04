internal class Program
{
    private static void Main(string[] args)
    {
            Console.Write("Introduceti primul an: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea an: ");
            int y2 = int.Parse(Console.ReadLine());

            int anBisect = 0;
            for (int i = y1; i <= y2; i++)
            {
                if (eBisect(i))
                {
                    anBisect++;
                }
            }

            Console.WriteLine($"Numarul de ani bisecti intre anii {y1} si {y2} este: {anBisect}");
     }

        static bool eBisect(int an)
        {
            return (an % 4 == 0 && (an % 100 != 0 || an % 400 == 0));
        }
    }
