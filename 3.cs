internal class Program
{
    private static void Main(string[] args)
    {
        // 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

        Console.WriteLine("Introdu pe n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdu pe k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        if (n % k == 0)
        {
            Console.WriteLine($"{n} se divide cu {k}");
        }
        else
        {
            Console.WriteLine($"{n} nu se divide cu {k}");
        }
    }
}