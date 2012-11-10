///**
// * System Operation: Accounting 
// * 1. Records the log of the events
// * 2. Calculates the commission of the salesperson
// * 3. Calculates the revenue and record
// * 4. Calculates the total tax from the profit 
// */

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CPSC462_POS
//{
//    class Accounting
//    {
//        private int store_id;
//        private decimal revenue = 0;
//        private decimal total_expense = 0;
//        private int tax_id = 0;
//        private decimal tax_rate = 0;
//        private int reference_id;

//        /**
//         * Constructor.
//         * 
//         * @param store_id is the ID of store accouting.  This is necessary to call proper information from database.
//         * @requires store_id must be valid ID. (Greater than 0)
//         * @ensure that the class get all necessary information from database.
//         */
//        public Accounting(int store_id)
//        {
//            this.store_id = store_id;

//            //Get detail information about the store accouting from database. (revenue, total_commission <expense>, tax_id, tax_rate)
//        }

//        /**
//         * This method records the inventory related event to the log database.
//         * This method will handle salesperson's commission if the event type is "restock"
//         * 
//         * @param type defines what type of inventory update: {purchase, return}
//         * @param reference_id is a ID of either Order No. or Return No.
//         * @param product is a product to change the inventory
//         * @param qty is a quantity that needs to be changed relative to the existing quantity.
//         * 
//         * @requires product exists in database. (Valid product)
//         * @requires qty is relative number (Ex: adding 1 => 1, removing 2 => -2)
//         * @ensure the product's qty >= 0 after applying the new qty.
//         */
//        public void record_inventory_log(String type, int reference_id, ProductSpecification product, int qty)
//        {
//            //1. Write log to database about the following information.
//            //2. If it is restock, add commission to the salesperson
//            //3. Else calculate the revenue
//            if (type == "restock") this.add_commission(reference_id, (decimal)product.price * qty);
//            else this.calculate_revenue((decimal)product.price * qty);
//        }

//        /**
//         * This method calls salesperson's add_commission to add the commission value.
//         * 
//         * @param salesperson_id must be valid ID (greater than 0)
//         * @param total must be positive number greater than 0
//         */
//        public void add_commission(int salesperson_id, decimal total)
//        {
//            SalesPerson salesperson = new SalesPerson(reference_id);
//            decimal commission = salesperson.get_commission(total);
//            salesperson.add_commission(commission);
//            salesperson.savedate();
//            this.total_expense += commission;
//        }

//        /**
//         * The method will update the total revenue of the store from the price.
//         *
//         * @param total is the total of the product(s) price
//         */
//        public void calculate_revenue(decimal total)
//        {
//            this.revenue += total;
//        }

//        /**
//         * This method will store the current data into database.
//         */
//        public void savedata()
//        {
//            //Store the current data into the database.
//        }

//        /**
//         * This method will calculate the total tax amount.
//         */
//        public decimal calculate_total_tax()
//        {
//            return (this.revenue - this.total_expense) * this.tax_rate;
//        }

//        /**
//         * This method will call Government TaxAgent API to pay the tax.
//         * Since TaxAgent is 3rd party software, the code is not available in our solution.
//         * 
//         * @requires valid tax ID to process the payment properly.
//         */
//        public void pay_tax()
//        {
//            TaxAgent tax_agent = new TaxAgent(this.tax_id);
//            tax_agent.pay(this.calculate_total_tax());
//        }
//    }
//}
