using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Globalization;

namespace CPSC462_POS
{
    class Address
    {
        private string address1;
        private string address2;
        private string city;
        private string state;
        private int zipcode;

        private string Address1
        {
            get { return address1; }
            set
            {
                if (value.Trim() == "")
                    throw new Exception("Address should not be empty");

                address1 = value.Trim();
            }
        }

        private string Address2
        {
            get { return address2; }
            set
            {
                address2 = value.Trim();
            }
        }

        private string City
        {
            get { return city; }
            set
            {
                if (value.Trim() == "")
                    throw new Exception("City should not be empty.");

                // Reference: http://msdn.microsoft.com/en-us/library/system.globalization.textinfo.totitlecase.aspx
                TextInfo ti = new CultureInfo("en-US", false).TextInfo;
                city = ti.ToTitleCase(value.Trim());
            }
        }

        private string State
        {
            get { return state; }
            set
            {
                if (value.Trim() == "")
                    throw new Exception("State should not be empty.");

                state = value.Trim().ToUpper();
            }
        }

        private int Zipcode
        {
            get { return zipcode; }
            set
            {
                if (Information.IsNumeric(value) && (value > 0) && (value <= 99999))
                    zipcode = value;
            }
        }

        public Address(int stNo, string addr1, string addr2, string city, string state, int zip)
        {
            this.Address1 = addr1;
            this.Address2 = addr2;
            this.City = city;
            this.State = state;
            this.Zipcode = zip;
        }

        public Address(string address)
        {
            string[] splitAddress = address.Split(',');
            int addressLength = splitAddress.Length;

            if (addressLength != 3 && addressLength != 4) return;

            this.Address1 = splitAddress[0];
            if (addressLength == 3)
            {
                this.City = splitAddress[1];
                this.State = splitAddress[2].Split()[0];
                this.Zipcode = Convert.ToInt32(splitAddress[2].Split()[1]);
            }
            else if (addressLength == 4)
            {
                this.Address2 = splitAddress[1];
                this.City = splitAddress[2];
                this.State = splitAddress[3].Split()[0];
                this.Zipcode = Convert.ToInt32(splitAddress[3].Split()[1]);
            }
        }

        public string getAddress()
        {
            return address1 + "\n" +
                (address2 == "" ? "" : (address2 + "\n")) +
                city + ", " +
                state + " " +
                zipcode;
        }

    }
}
