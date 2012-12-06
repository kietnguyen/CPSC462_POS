using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Windows.Forms;

namespace CPSC462_POS
{
    /** \class Address
     *  \brief Address includes address 1, address 2, city, state, and zip code.
     *  
     *  \deta
     * 
     */
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
                if (String.IsNullOrEmpty(value.Trim()))
                    MessageBox.Show("Address should not be empty");

                address1 = value.Trim();
            }
        }

        /*
         * 
         */
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
                if (String.IsNullOrEmpty(value.Trim()))
                    MessageBox.Show("City should not be empty.");

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
                if (String.IsNullOrEmpty(value.Trim()))
                    MessageBox.Show("State should not be empty.");

                state = value.Trim().ToUpper();
            }
        }

        private int Zipcode
        {
            get { return zipcode; }
            set
            {
                if (!Information.IsNumeric(value) || (value <= 0) || (value > 99999))
                {
                    MessageBox.Show("Invalid zip code.");
                }
                    
                zipcode = value;
            }
        }

        public Address(string addr1, string addr2, string city, string state, int zip)
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

            if (addressLength != 3 && addressLength != 4)
            {
                MessageBox.Show("Incorrect address format.");
            }

            this.Address1 = splitAddress[0];
            string[] splitStateZip;
            switch (addressLength)
            {
                case 3:
                    this.City = splitAddress[1];
                    splitStateZip = splitAddress[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    this.State = splitStateZip[0];
                    this.Zipcode = Convert.ToInt32(splitStateZip[1]);
                    break;

                case 4:
                    this.Address2 = splitAddress[1];
                    this.City = splitAddress[2];
                    splitStateZip = splitAddress[3].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    this.State = splitStateZip[0];
                    this.Zipcode = Convert.ToInt32(splitStateZip[1]);
                    break;
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
