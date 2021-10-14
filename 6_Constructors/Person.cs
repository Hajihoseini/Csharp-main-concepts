using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Constructors
{
    class Person
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }



     
        public Person()
        {
            Orders = new List<Order>();
        }



        public Person(int id)
            :this()
        {
            this.Id = id;
        }



        public Person(int id,string firstName,string lastName)
            :this(id)
        {

            FirstName = firstName;
            LastName = lastName;

        }


    }
}
