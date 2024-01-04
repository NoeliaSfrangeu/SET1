internal class Program
{
    private static void Main(string[] args)
    {
       // 14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 

            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Numarul {n} ");
            if (!estePalindrom(n))
                Console.Write("nu ");
            Console.WriteLine("este palindrom");
    }

    static int oglindit(int n)
    {
        int result = 0;
        int cifra;
        while (n > 0)
        {
          cifra = n % 10;
          n = n / 10;
          result = result * 10 + cifra;
        }

            return result;
    }

    static bool estePalindrom(int n)
    {
        return n == oglindit(n);
    }
}
