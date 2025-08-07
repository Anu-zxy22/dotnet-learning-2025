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
           Employee employee = new Developer();
            employee.Work();




            //corrected downcast

            Developer developer=(Developer)employee;
            developer.WriteCode();






            //upcast
            Device device = new SmartPhone();
            device.Start();

            //corrected downcast

            SmartPhone phone = (SmartPhone)device;
            phone.Start("restart");




        }
    }

    public class Employee { 
        public virtual void Work()
        {
            Console.WriteLine("Base class work");
        }
    }

    public class Developer:Employee { 
        public override void Work()
        {
            Console.WriteLine("Derived work");
        }
        public void WriteCode()
        {
            Console.WriteLine("Child class code");
        }
    }















    //Realistic Task
    public class Device
    {
        public virtual void Start()
        {
            Console.WriteLine("First Start");
        }

        //public void Start(string mode)
        //{
        //    Console.WriteLine("Second start with the mode:"+mode);
        //}

    }


    //to override always inherit?

    public class SmartPhone:Device
    {
        public override void Start()
        {
            Console.WriteLine("First Start of Smartphone");
        }
        public void Start(string mode)
        {
            Console.WriteLine("Second start with the mode:" + mode);
        }
    }



}
