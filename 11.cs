using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Afisati in ordine inversa cifrele unui numar n. 
        Console.Write("Introduceti un numar: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Cifrele in ordine inversa sunt: ");
        int result = 0;
        int cifra;
           while (n > 0)
           {
            cifra = n % 10;
            n = n / 10;
            result = result * 10 + cifra;
           }
        Console.Write(result);
    }
    }
