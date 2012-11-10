/**
 * System Operation: SalesPerson
 * 1. Manages sales person's commission rate
 * 2. Manages sales person's total commission
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class SalesPerson
    {
        private int salesperson_id;
        private String firstname;
        private String lastname;
        private String contact;
        private String email;
        private float commission_rate = 0;
        private float total_commission = 0;

        /**
         * Constructor.
         * 
         * @param store_id is the ID of store accouting.  This is necessary to call proper information from database.
         * @requires store_id must be valid ID. (Greater than 0)
         * @ensure that the class get all necessary information from database.
         */
        public SalesPerson(int salesperson_id)
        {
            this.salesperson_id = salesperson_id;
            //Get detail information about the store accouting from database. (names, email, contact, commission_rate & total_commission)
        }

        /**
         * This method adds the commission value to the total commission.
         * 
         * @param commission is the commission that the sales person earned.
         */
        public void add_commission(float commission)
        {
            this.total_commission += commission;
        }

        /**
         * This method will calculate and return the total commission that the sales person earned.
         * 
         * @param total is the total price of products that the sales person sold to the company.
         */
        public float get_commission(float total)
        {
            return total * this.commission_rate;
        }

        /**
         * This method stores the current value into the database.
         */
        public void savedata()
        {
            //Store the current data into the database.
        }

        internal decimal get_commission(decimal total)
        {
            throw new NotImplementedException();
        }

        internal void add_commission(decimal commission)
        {
            throw new NotImplementedException();
        }

        internal void savedate()
        {
            throw new NotImplementedException();
        }
    }
}
