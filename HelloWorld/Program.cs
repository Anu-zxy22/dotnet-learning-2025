namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, C#");

            
            Console.Write("What's your name? ");
            string userInputName = Console.ReadLine();
            Console.WriteLine("Welcome, " + userInputName + "!");

            
            int myAge = 21;
            string myName = "Anu";
            double? myHeight =null;
            var name = "Anu";
            try
            {
                int bmi = Convert.ToInt16(name);
            }
            catch(System.FormatException)
            {
                Console.WriteLine("Name can't be converted to integer");
            }
            
           
            Console.WriteLine("\n--- Sample Profile ---");
            Console.WriteLine("Name   : " + myName);
            Console.WriteLine("Age    : " + myAge + " years old");
            Console.WriteLine("Height : " + myHeight + " feet");

            
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
