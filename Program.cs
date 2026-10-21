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
            //if i divisible by 3, FizzBuzz = Fizz, else nothing
            FizzBuzz = i % 3 == 0 ? "Fizz" : "";
            /*if i divisible by 5, FizzBuzz += Fizz, else nothing
             += -> to include FizzBuzz = FizzBuzz*/
            FizzBuzz += i % 5 == 0 ? "Buzz" : "";
            //if FizzBuzz is empty, add i to Result, if not add FizzBuzz
            Result += FizzBuzz == "" ? i : FizzBuzz;
            /*BONUS
             every 10 numbers, new line*/
            Result += i % 10 == 0 ? "|\n" : "|";
        }
        Console.WriteLine(Result);
    }
}