using System;

namespace Enumerated_type
{

    public enum MilitaryServiceStatus
    {
        Done,
        Moaf,
        Mashmool,
        Farary
    }

    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public MilitaryServiceStatus militaryServiceStatus { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Person person = new()
            {
                militaryServiceStatus = MilitaryServiceStatus.Done
            };
              

            if(person.militaryServiceStatus == MilitaryServiceStatus.Farary)
            {
                Console.WriteLine("He is Rejected ....");
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
