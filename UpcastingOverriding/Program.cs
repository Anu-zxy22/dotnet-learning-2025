using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer();  


        }
    }

    public class Employee { 
        public void Work()
        {
            Console.WriteLine("Base class work");
        }
    }

    public class Developer { 
        public void Work()
        {
            Console.WriteLine("Derived work");
        }
    }


}
