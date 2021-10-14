using System;

namespace _6_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling Person class with No1 constructor //
            var person = new Person(1,"Saeid","Hajihoseini");



            var order = new Order()
            {
                Id = 1,
                OrderName = "Nike shoe",
                Price = 8500
            };
            person.Orders.Add(order);

            var order2 = new Order()
            {
                Id = 2,
                OrderName = "Apple iphone12",
                Price = 900
            };
            person.Orders.Add(order2);



            Console.WriteLine($"first name: {person.FirstName}, last name: {person.LastName} as id {person.Id}");

            foreach(var item in person.Orders)
            {
                Console.WriteLine($"{item.Id} - item => {item.OrderName} , price => {item.Price} ");
            }
        }
    }
}
