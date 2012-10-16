using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace CPSC462_POS
{
    class Address
    {
        private string _address1
        {
            get { return _address1; }
            set
            {
                if (value != "")
                    _state = value.Trim();
            }
        }

        private string _address2
        {
            get { return _address2; }
            set
            {
                _address2 = value.Trim();
            }
        }

        private string _city
        {
            get { return _city; }
            set
            {
                if (value != "")
                    _city = value.Trim();
            }
        }

        private string _state
        {
            get { return _state; }
            set
            {
                if (value != "")
                    _state = value.Trim();
            }
        }

        private int _zipcode
        {
            get { return _zipcode; }
            set
            {
                if (Information.IsNumeric(value) && (value > 0) && (value <= 99999))
                    _zipcode = value;
            }
        }

        public string getAddress()
        {
            return _address1 + "\n" +
                (_address2 == "" ? "" : (_address2 + "\n")) +
                _city + ", " +
                _state + " " +
                _zipcode;
        }

        public Address(int stNo, string addr1, string addr2, string city, string state, int zip)
        {
            this._address1 = addr1;
            this._address2 = addr2;
            this._city = city;
            this._state = state;
            this._zipcode = zip;
        }

    }
}
