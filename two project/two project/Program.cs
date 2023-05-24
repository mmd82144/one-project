using System;

namespace two_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("pls enter a nambr");
            string number = Console.ReadLine();
            x = int.Parse(number);

            x *=3;
            
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
