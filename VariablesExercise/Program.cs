namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //declaring and initializing variables
            string greeting = "Hello! It is very nice to meet you!";
            int age = 5;
            char grade = 'A';
            bool isSleepy = true;
            double amountDue = 5.5;
            decimal height = 5.2m;


            //interpolation

            Console.WriteLine($"Sometimes, the child would say to strangers, '{greeting}', which was a problem because she was only {age} years old.Fortunately, she tended to earn the grade of {grade} in school, even though it is {isSleepy} that she was sleepy quite often.Nonetheless, she paid the {amountDue} that she owed, and then was fined even more money because whe was only {height} feet tall.");


        }
    }
}
