internal class Program
{
    private static void Main(string[] args)
    {
        // 9.Afisati toti divizorii numarului n.

        Console.WriteLine("Introdu pe n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Divizorii lui {n} sunt: ");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.Write($"{i} ");
            }
        }

    }
}