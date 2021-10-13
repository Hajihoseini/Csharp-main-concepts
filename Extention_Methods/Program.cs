using System;

namespace Extention_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string nn = Console.ReadLine();
                if(nn.IsNationalCode())
            {
                Console.WriteLine("Is valid national code!");
            }
            
        }
    }
}
