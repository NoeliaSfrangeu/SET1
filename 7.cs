internal class Program
{
    private static void Main(string[] args)
    {
        // 7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        int a, b, aux;
        Console.WriteLine("Introdu a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introdu b: ");
        b = int.Parse(Console.ReadLine());
        aux = a;
        a = b;
        b = aux;
        Console.WriteLine($"a = {a}, b = {b}");
    }
}
