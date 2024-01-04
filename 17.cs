internal class Program
{
    private static void Main(string[] args)
    {
        // 17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        Console.Write("Introduceti primul numar: ");
        int nr1 = int.Parse(Console.ReadLine());

        Console.Write("Introduceti al doilea numar: ");
        int nr2 = int.Parse(Console.ReadLine());

        int cmmd = Euclid(nr1, nr2);
        int cmm = (nr1 / cmmd) * nr2;

        Console.WriteLine($"Cel mai mare divizor comun al {nr1} si {nr2} este: {cmmd}");
        Console.WriteLine($"Cel mai mic multiplu comun al {nr1} si {nr2} este: {cmm}");
    }

    static int Euclid(int x, int y)
    {
        if (x == 0)
            return y;
        else
            return Euclid(y % x, x);
    }
}