using System;

namespace project_one
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name");
            name =Console.ReadLine();

            Console.WriteLine("hello "+ name);
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
