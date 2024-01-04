internal class Program
{
    private static void Main(string[] args)
    {
        //Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 

            Console.WriteLine("Introduceti un numar :");
            int n = int.Parse(Console.ReadLine());
            int a;
            int b = 0;
            int nrOrig = n;
            a = n % 10;
            while (n != 0)
            {
                if (n % 10 != a)
                {
                    b = n % 10;
                    break;
                }
                n /= 10;
            }
            bool ok = true;
            while (n != 0)
            {
                if (n % 10 != b && n % 10 != a)
                    ok = false;
                n /= 10;
            }
            if (ok)
                Console.WriteLine($"Numarul {nrOrig} este scris doar cu doua cifre care se pot repeta");
            else
                Console.WriteLine($"Numarul {nrOrig} nu este scris doar cu doua cifre care se pot repeta");
    }
}