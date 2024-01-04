internal class Program
{
    private static void Main(string[] args)
    {
        // 15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
        Console.Write("Introduceti primul numar: ");
        int numar1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int numar2 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al treilea numar: ");
        int numar3 = int.Parse(Console.ReadLine());

        int[] numereSortate = sortare (numar1, numar2, numar3);
        Console.WriteLine($"Numerele in ordine crescatoare sunt: {numereSortate[0]}, {numereSortate[1]}, {numereSortate[2]}");
    }
    static int[] sortare(int a, int b, int c)
    {
        int[] numere = { a, b, c };
        Array.Sort(numere);
        return numere;
    }
}
