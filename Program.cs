namespace fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        // Créez une application console qui affiche tous les nombres de 1 à 100 inclus, à l’exception de certains nombres.
        // Tous les nombres divisibles par 3 seront remplacés par le mot “Fizz”.
        // Tous les nombres divisibles par 5 seront remplacés par le mot “Buzz”.
        // Tous les nombres qui sont divisibles à la fois par 3 et à la fois par 5 seront remplacés par le mot “FizzBuzz”.
        String Result = "";
        String FizzBuzz;
        for(int i = 1; i <= 100; i++)
        {
            FizzBuzz = "";
            FizzBuzz = i % 3 == 0 ? "Fizz" : "";
            FizzBuzz += i % 5 == 0 ? "Buzz" : "";
            Result += FizzBuzz == "" ? i : FizzBuzz;
            Result += i % 10 == 0 ? "|\n" : "|";
        }
        Console.WriteLine(Result);
    }
}