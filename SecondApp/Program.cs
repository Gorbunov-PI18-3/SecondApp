using System;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "My own name";
            Console.WriteLine(MyName);
            Console.WriteLine("\t Hello, world!");
            Console.WriteLine("\t I'm 20 yo");
            Console.WriteLine("\t My name is \n Slava");

            Console.WriteLine("\u0040");
            Console.WriteLine("\x23");

            string My2Name = "Jane";
            byte Age = 27;
            bool Pet = true;
            double Shoes = 37.5;



            Console.WriteLine("My name is " + My2Name);
            Console.WriteLine("My age is " + Age);
            Console.WriteLine("Do I have a pet " + Pet);
            Console.WriteLine("My shoe size is " + Shoes);

            Console.ReadKey();
        }
    }
}
