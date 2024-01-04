internal class Program
{
    private static void Main(string[] args)
    {
        //10.Test de primalitate: determinati daca un numar n este prim.

            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());

            if (estePrim(n))
            {
                Console.WriteLine($"{n} este un numar prim.");
            }
            else
            {
                Console.WriteLine($"{n} nu este un numar prim.");
            }
        }

        static bool estePrim(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
