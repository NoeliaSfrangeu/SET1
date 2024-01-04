internal class Program
{
    private static void Main(string[] args)
    {
        // 12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 

        Console.Write("Introduceti prima cifra a intervalului: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Introduceti ultima cifra a intervalului: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Introduceti nr. cu care sa fie divizibile: ");
        int n = int.Parse(Console.ReadLine());

        int cont = contNrDiv(a, b, n);

        Console.WriteLine($"Numerele divizibile cu {n} in intervalul [{a}, {b}] sunt: {cont}");
    }

    static int contNrDiv(int a, int b, int n)
    { 
        int cont = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % n == 0)
            {
                cont++;
            }
        }

        return cont;
        }
    }

