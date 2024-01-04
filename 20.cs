internal class Program
{
    private static void Main(string[] args)
    {
        // 20.Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).

        Console.Write("Introduceti numaratorul: ");
            int numarator = int.Parse(Console.ReadLine());

            Console.Write("Introduceti numitorul: ");
            int numitor = int.Parse(Console.ReadLine());

            Console.Write($"{numarator / numitor},");
            int parteFractionara = numarator % numitor;
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFractionara);
            bool periodic = false;

            do
            {
                cifra = parteFractionara * 10 / numitor;
                cifre.Add(cifra);
                rest = parteFractionara * 10 % numitor;

                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }

                parteFractionara = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (int item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
    }
