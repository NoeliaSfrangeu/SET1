internal class Program
{
    private static void Main(string[] args)
    {
        //2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. 

        Console.WriteLine("Introdu coeficientul a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introdu coeficientul b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Introdu termenul liber c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double delta = b * b - 4 * a * c;
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Solutia este x1 = {x1} , x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Solutia este: x = {x}");
        }
        else
        {
            Console.WriteLine("In cazul in care delta < 0, delta apartine multimii vide");
        }
    }
}