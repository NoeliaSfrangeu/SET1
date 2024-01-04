internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introduceti primul numar: ");
        int numar1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int numar2 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al treilea numar: ");
        int numar3 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al patrulea numar: ");
        int numar4 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al cincilea numar: ");
        int numar5 = int.Parse(Console.ReadLine());

        AfisOrdCres(ref numar1, ref numar2, ref numar3, ref numar4, ref numar5);

        Console.WriteLine($"Numerele in ordine crescatoare sunt: {numar1}, {numar2}, {numar3}, {numar4}, {numar5}");
    }

    static void AfisOrdCres(ref int a, ref int b, ref int c, ref int d, ref int e)
    {
        Ordoneaza(ref a, ref b);
        Ordoneaza(ref a, ref c);
        Ordoneaza(ref a, ref d);
        Ordoneaza(ref a, ref e);

        Ordoneaza(ref b, ref c);
        Ordoneaza(ref b, ref d);
        Ordoneaza(ref b, ref e);

        Ordoneaza(ref c, ref d);
        Ordoneaza(ref c, ref e);

        Ordoneaza(ref d, ref e);
    }

    static void Ordoneaza(ref int x, ref int y)
    {
        if (x > y)
        {
            int aux = x;
            x = y;
            y = aux;
        }
    }
}