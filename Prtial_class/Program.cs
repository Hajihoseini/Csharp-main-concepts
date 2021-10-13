using System;

namespace Prtial_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Saeid",
                LastName = "Haji Hoseini",
                FatherName = "Mohsen",
                militaryServiceStatus = MilitaryServiceStatus.Done
            };

            Console.WriteLine($"Name is{person.FirstName} {person.LastName} , father name : {person.FatherName} . military : {MilitaryServiceStatus.Done} ");
        }


        public void TestPartial()
        {
            var person = new Person
            {
                FirstName = "Saeid",
                LastName = "Haji Hoseini",
                FatherName = "Mohsen",
                militaryServiceStatus = MilitaryServiceStatus.Done
            };
        }
    }
}
