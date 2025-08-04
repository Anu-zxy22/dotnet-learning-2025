using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Calculate Age

            Console.Write("Enter your birthdate (YYYY-MM-DD): ");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;

            int currentAge = today.Year - dob.Year;
            

            Console.WriteLine("You are "+currentAge+" yrs old");





            //Adding days 


            Console.Write("Enter a starting date (YYYY-MM-DD): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("How many days would you like to add? ");
            int additionalDays = int.Parse(Console.ReadLine());

           // DateTime updatedDate =
            //Console.WriteLine("The new date is: "+updatedDate);







            //Day of week inputDate.DayOfWeek

            Console.Write("Type a date to find the day of the week (YYYY-MM-DD): ");
            DateTime inputDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("The day on that date is: "+ inputDate.DayOfYear);





            //Comma-Separated Words 


            Console.Write("Enter number of words: ");
            int n = int.Parse(Console.ReadLine());

            StringBuilder wordsList = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter word: ");
                string input = Console.ReadLine();

                //wordsList.;

                if (i != n - 1)
                {
                    wordsList.Append(", ");
                }
            }

            Console.WriteLine("Combined words: " + wordsList);







            //replace word


            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Word to find: ");
            string wordToFind = Console.ReadLine();

            Console.Write("Word to replace it with: ");
            string newWord = Console.ReadLine();

            string updated = sentence.Replace(wordToFind, newWord);
            StringBuilder finalSentence = new StringBuilder(updated);

            Console.WriteLine("Modified sentence: " + finalSentence);




            //static


            // In Main method
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();

            Console.WriteLine("Number of students created: " + s1.Count);
            Console.WriteLine("Number of students created: " + s2.Count);



            //visitor class


            // In Main method
            Visitor v1 = new Visitor("V01");
            Visitor v2 = new Visitor("V02");
            Visitor v3 = new Visitor("V03");
            Visitor v4 = new Visitor("V04");
            Visitor v5 = new Visitor("V05");

            Console.WriteLine("Visitorcount: " + Visitor.visitorCount);







        }
    }



    class Student
    {
        public readonly int Count = 0;

        public Student()
        {
            Count++;
        }









        

    }


    class Visitor
    {
        public static int visitorCount = 0;
        public readonly string visitorID;
        public const string Category = "General";

        public Visitor(string id)
        {
            visitorID = id;
            visitorCount++;
        }
    }

}
