namespace fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        // Créez une application console qui affiche tous les nombres de 1 à 100 inclus, à l’exception de certains nombres.
        for (int i = 1; i <= 100; i++)
        {
            Console.Write("|");
            
            if (i % 3 == 0 && i % 5 == 0)
            {
                // Si l'itération courante est un multiple de 3 ET de 5
                Console.Write("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                // Sinon, si l'itération courante est un multiple de 3
                Console.Write("  Fizz  ");
            }
            else if (i % 5 == 0)
            {
                // Sinon, si l'itération courante est un multiple de 5
                Console.Write("  Buzz  ");
            }
            else
            {
                // Lorsque aucune des options ci-dessus ne passe, on affiche simplement le nombre
                // On ajoute des espaces pour aligner un peu les nombres
                if (i < 10)
                {
                    Console.Write("    " + i + "   ");
                } else if (i < 100) {
                    Console.Write("   " + i + "   ");
                }
            }
            
            // Mettre à la ligne tous les 10 nombres
            if (i % 10 == 0)
            {
                Console.Write("|\n");
            }
        }
    }
}