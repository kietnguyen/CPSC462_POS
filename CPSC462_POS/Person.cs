using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dob;
        private string address;

        public Person()
        {

        }

        public Person(int id, string first, string last, DateTime dob, string address)
        {
            this.firstName = first;
            this.lastName = last;
            this.dob = dob;
            this.address = address;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public virtual string showId()
        {
            return this.firstName + " " + this.lastName + "\n" +
                    this.dob + "\n" +
                    this.address;
        }
    }
}
