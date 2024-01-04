internal class Program
{
    private static void Main(string[] args)
    {
        //5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.

        Console.WriteLine("Introduceti un nr. : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introdueti k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        while (i < k)
        {
            n /= 10;
            i++;
        }
        Console.WriteLine(n % 10);
    }
}