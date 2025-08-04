using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userName = "Modi";
            String passWord = "pass123";
            double balance = 0;

            Console.Write("1.Login");
            Console.WriteLine("2.Exit");
            Console.Write("Enter code:");

            //input of code

            int code=Convert.ToInt32(Console.ReadLine());

            if(code==2)
            {
                Console.WriteLine("You can exit the program");
            }
            else if(code==1)
            {
                //Login

                Console.WriteLine("Enter Username:");
                String nameInput = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string pwdInput = Console.ReadLine();

                if (nameInput != userName || pwdInput != passWord)
                {

                    Console.WriteLine("Incorrect username or password");
                }

                else if(nameInput==userName && pwdInput==passWord)
                 {
                    Console.WriteLine("");
                    Console.WriteLine("Welcome " + userName);
                    Console.WriteLine("");


                    //display options


                    Console.WriteLine("You can");
                    Console.WriteLine("1.Check Balance");
                    Console.WriteLine("2.Deposit");
                    Console.WriteLine("3.Withdraw");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("");
                    Console.WriteLine("Enter a number from 1 to 4 to select the option");

                    int OptionNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("");


                    if (OptionNumber == 4)
                    {

                        Console.WriteLine("You can exit the program");
                    }

                    else if (OptionNumber == 1)
                    {
                        Console.WriteLine("Balance: ₹");
                        Console.Write(Math.Round(balance, 2));

                    }
                    else if (OptionNumber == 2)
                    {
                        Console.WriteLine("Enter deposit amount:");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine("Current balance is :₹" + Math.Round(balance, 2));
                    }

                    else if (OptionNumber == 3) {

                        Console.WriteLine("Enter amount to withdraw:");
                        double withdrawInput= Convert.ToDouble(Console.ReadLine());

                        if(withdrawInput>balance)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Error.Re-enter correct amount");

                        }
                        else if(withdrawInput<balance || withdrawInput==balance)
                        {
                            balance-=withdrawInput;
                            Console.WriteLine("Current balance is:₹" + Math.Round(balance, 2));


                        }
                    }


                }
            }
           


            




        }
    }
}
