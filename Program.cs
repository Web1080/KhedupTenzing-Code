//1.0 predefined namespace

using System;

//1.1 custom defined namespace
namespace helloWorld
{
    class Program
    {
        //execution starts here
                //Commandline arguments
                // vvv
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello World! " +DateTime.Now);
            string firstname, lastname;
            Console.WriteLine("Please Enter Your First Name: ");
            firstname = Console.ReadLine(); //Takes user's input in string form
            //Console.WriteLine("Welcome " +firstname + " " +lastname); //String concatation
            Console.WriteLine("Please Enter Your Last Name: ");
            lastname = Console.ReadLine();
            Console.WriteLine($"Welcome {firstname} {lastname}"); //String interpolation
        }
    }
}
