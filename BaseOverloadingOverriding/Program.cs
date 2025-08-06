using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseOverloadingOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add(1, 2);
            //Add()

            Calculator obj = new Calculator();

            Console.WriteLine(obj.Add(1,2));
            Console.WriteLine(obj.Add(2.3,2.3));
            Console.WriteLine(obj.Add("pink","villa"));

            //shapecircle override

            Shape shape = new Shape();
            Circle circle=new Circle();

            shape.Draw();
            circle.Draw();



            //corrected 
            ColorPrinter1 printer = new ColorPrinter1();
            printer.PrintMessage1();


            Shape1 shape1 = new Shape1();
            Circle1 circle1 = new Circle1();

            shape1.Draw1();
            circle1.Draw1();



        }
    }

    public class Printer
    {
        public void PrintMessage()
        {
            Console.WriteLine("Base Printer Message");
        }

    }
    public class ColorPrinter
    {
        public void PrintMessage()
        {
            Console.WriteLine("ColorPrint");
        }

    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + b;

        }





    }

    public class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing shape");
        }
    }

    public class Circle
    { 
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }























    //corrected

    public class Printer1
    { 
        public virtual void PrintMessage1()
        {
            Console.WriteLine("Printer1 mssg");
        }
    }

    public class ColorPrinter1 : Printer1
    {
        public override void PrintMessage1()
        {
            base.PrintMessage1();
            Console.WriteLine("ColorPrinter1 mssg");
        }
    }



    public class Shape1
    {
        public virtual void Draw1()
        {
            Console.WriteLine("Shape1 mssg");

        }
    }

    public class Circle1 : Shape1
    {
        public override void Draw1()
        {
            
            Console.WriteLine("circle1 mssg");
        }
    }





}
