using System;

namespace Extention_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your code :");
            string nn = Console.ReadLine();
                if(nn.IsNationalCode())
            {
                Console.WriteLine("Is valid national code!");
                Console.ReadKey();
            }
            
        }
    }
}
