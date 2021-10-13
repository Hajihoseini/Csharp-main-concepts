using System;

namespace nullable_dataTypes
{

    public class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } = "HajiHoseini";
    }



    class Program
    {
        static void Main(string[] args)
        {

            int age = 5;
            int? BirthDay = null;
            if(BirthDay.HasValue)
            {
                Console.WriteLine($"The value is {BirthDay.Value}");

            }
            else
            {
                Console.WriteLine("There is no value to print ...");
            }
            int newBirthDay = BirthDay ?? 18;
            Console.WriteLine($"The newBirthDay is {newBirthDay}");


            //========================================================= Check null string 

            person person = new();
            Console.WriteLine($"{person?.FirstName}");
            Console.WriteLine($"{person.LastName}");

        }
    }
}
