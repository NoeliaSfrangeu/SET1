using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        // 18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2 ^ 3 x 3 ^ 1 x 7 ^ 2.

        Console.Write("Introduceti un numar: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Descompunerea in factori primi ai numarului {n} este: ");
        descomp(n);
    }

    static void descomp(int nr)
    {
        int x = 2;
        int y;
        while (nr > 1)
        {
            y = 0;
            while (nr % x == 0)
            {
                y++;
                nr /= x;
            }

            if (y > 0)
            {
                Console.Write($"{x}^{y}");

                if (nr > 1)
                {
                    Console.Write(" x ");
                }
            }

            x++;
            if (nr > 1 && x * x > nr)
            {
                x = nr;
            }
        }

        Console.WriteLine();
    }
}   