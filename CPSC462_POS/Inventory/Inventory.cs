///**
// * System Operation: Update Inventory (Inventory Manager)
// * 
// */

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace CPSC462_POS
//{
//    class Inventory
//    {
//        private Accounting accounting;
//        private DBConnect database;

//        /**
//         * Constructor.
//         * 
//         * @param accouting is the accounting class that is defined in the main class
//         */
//        public Inventory(Accounting accounting)
//        {
//            this.accounting = accounting;
//        }

//        /**
//         * This method updates the qty of the item
//         * This method is called when the customer purchase/returns product and updates the quantity
//         * This method is called when the salesperson supplied the product and updates the quantity.
//         * This method calls Accouting's record_inventory_log method to store the transaction record into the database.
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
//        public void updateInventory(String type, int reference_id, ProductSpecification product, int qty)
//        {
//            product.setStock(product.getStock() + qty);
//            this.reportAccounting(type, reference_id, product, qty);
//            this.accouting.record_inventory_log(type, reference_id, product, qty);
//        }

//        /**
//         * This method is used to add the supplies supplied by salesman.
//         * 
//         * @param salesperson_id ID of sales person
//         * @param product is the product to add the inventory
//         * @param qty is the number of item that will be added.
//         */
//        public void AddSupplies(int salesperson_id, ProductSpecification product, int qty)
//        {
//            this.updateInventory("restock", salesperson_id, product, qty);
//        }

//        /**
//         * This method is used to deduct inventory after sale.
//         * @param salesperson_id ID of employee who used POS
//         * @param product is the product to add the inventory
//         * @param qty is the number of item that will be added.
//         */
//        public void purchaseItem(int employee_id, ProductSpecification product, int qty)
//        {
//            this.updateInventory("sold", employee_id, product, qty);
//        }

//        /**
//         * This method is used to add the inventory after return process.
//         * @param salesperson_id ID of employee who used POS
//         * @param product is the product to add the inventory
//         * @param qty is the number of item that will be added.
//         */
//        public void returnItem(int employee_id, ProductSpecification product, int qty)
//        {
//            this.updateInventory("return", employee_id, product, qty);
//        }
//    }
//}
