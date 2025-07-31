namespace Secondthirdfourth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.Write("Enter first number to add: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number to add: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int Result = num1 + num2;
            Console.WriteLine($"Sum = {Result}");


            //MULTIPLY

            Console.Write("Enter first number to multiply: ");
            int mult1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter second number to multiply: ");
            int mult2 = Convert.ToInt32(Console.ReadLine());



            int product = mult1 * mult2;
            Console.WriteLine($"Product = {product}");








            //THIRD QUESTION



            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("You are eligible to vote.");
            else
                Console.WriteLine("You are not eligible to vote.");

            //----------------------3B-----------------------------------------------------


            Console.Write("Enter a number to check if positive, negative or zero: ");
            int inputnum = Convert.ToInt32(Console.ReadLine());

            if (inputnum > 0)
                Console.WriteLine("The number is positive.");
            else if (inputnum < 0)
                Console.WriteLine("The number is negative.");
            else
                Console.WriteLine("The number is zero.");


            //3C---------------------------------------------------------EVEN OR ODD----------------------


            Console.Write("Enter a number to check even or odd: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
                Console.WriteLine("It is an even number.");
            else
                Console.WriteLine("It is an odd number.");


            //FOURTHQUESTION------------------------------------------------



            Console.WriteLine("Numbers from 1 to 10:");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }


            //SUM----------------------------------------------------------------

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine("\nSum of numbers from 1 to 100: " + sum);



            //EVENNUMBER----------------------------------------------------------

            Console.WriteLine("Even numbers between 1 and 20:");
            int n = 2;
            while (n <= 20)
            {
                Console.Write(n + " ");
                n += 2;
            }







        }
    }
}
