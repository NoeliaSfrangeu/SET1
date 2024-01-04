internal class Program
{
    private static void Main(string[] args)
    {
        // 4.Detreminati daca un an y este an bisect. 
        Console.WriteLine("Se va verifica daca anul urmator este bisect: ");
        int y = Convert.ToInt32(Console.ReadLine());
        if (y % 4 == 0)
        {
            Console.WriteLine($"{y} este an bisect.");
        }
        else if (y % 100 == 0)
        {
            Console.WriteLine($"{y} nu este an bisect");
        }
        else if (y % 100 == 0 && y % 400 == 0)
        {
            Console.WriteLine($"{y} este an bisect");
        }
        else
        {
            Console.WriteLine($"{y} nu este an bisect");
        }
    }
}