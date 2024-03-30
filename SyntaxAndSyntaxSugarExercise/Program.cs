namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9);
            if (answer < 9)
            {
                Console.WriteLine($"{answer} is less than nine");
            }
            else
            {
                Console.WriteLine($"{answer} is greater than or equal to nine");
            }

            var message = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine" ;
            Console.WriteLine(message);

        }
    }
}
