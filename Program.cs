namespace fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        // Créez une application console qui affiche tous les nombres de 1 à 100 inclus, à l’exception de certains nombres.
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                // Si l'itération courante est un multiple de 3 ET de 5
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                // Sinon, si l'itération courante est un multiple de 3
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                // Sinon, si l'itération courante est un multiple de 5
                Console.WriteLine("Buzz");
            }
            else
            {
                // Lorsque aucune des options ci-dessus ne passe, on affiche simplement le nombre
                Console.WriteLine(i);
            }
        }
    }
}