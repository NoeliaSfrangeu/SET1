internal class Program
{
    private static void Main(string[] args)
    {
        // 6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

        Console.WriteLine("Introdu pe a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdu pe b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdu pe c");
        int c = Convert.ToInt32(Console.ReadLine());
        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Lungimile laturilor trebuie sa fie pozitive si > 0");
        }
        else if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine($"{a}, {b} si {c} pot fi lungimile laturilor unui triunghi.");
        }
    }
}
