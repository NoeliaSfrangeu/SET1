internal class Program
{
    private static void Main(string[] args)
    {
        // 8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.

        int a, b;
        Console.WriteLine("Introdu a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introdu b: ");
        b = int.Parse(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"a = {a}, b = {b}");
    }
}