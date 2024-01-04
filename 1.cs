internal class Program
{
    private static void Main(string[] args)
    {

        // 1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        Console.WriteLine("Introdu coeficientul a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("In ecuatia de gradul 1 a trebuie sa fie diferit de 0.");
        }
        else
        {
            Console.WriteLine("Introdu termenul liber b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine($"Rezultatul ecuatiei este: x = {x}");
        }
    }
}