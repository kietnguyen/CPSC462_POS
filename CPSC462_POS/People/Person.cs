using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CPSC462_POS
{
    class Person
    {
        private string firstName;
        private string lastName;
        private DateTime dob;
        private Address address;
        private TextInfo ti = new CultureInfo("en-US", false).TextInfo;

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                this.firstName = ti.ToTitleCase(value);
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                this.lastName = ti.ToTitleCase(value);
            }
        }

        private DateTime DOB { get; set; }

        private Address Address { get; set; }

        public Person(string first, string last, string dob, string address)
        {
            this.firstName = first;
            this.lastName = last;
            this.dob = Convert.ToDateTime(dob);
            this.address = new Address(address);
        }

        public virtual string showId()
        {
            return FirstName + " " + LastName + "\n" +
                    DOB + "\n" +
                    Address;
        }
    }
}
