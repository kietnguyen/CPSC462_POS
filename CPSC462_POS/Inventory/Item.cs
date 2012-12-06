using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Item
    {
        private int itemId;
        private ProductSpecification productSpec;
        private decimal price;

        public int ItemId { get { return itemId; } }
        public string Name { get { return productSpec.Name; } }
        public decimal Price { get { return price; } }

        public Item(int itemId, ProductSpecification spec, decimal price)
        {
            this.itemId = itemId;
            this.productSpec = spec;
            this.price = price;
        }

        public Item getItem(int itemId)
        {
            Item item = DBConnect.GetInstance.retrieveItem(itemId);

            if (item == null)
                throw new Exception("Invalid item id.");

            return item;
        }


    }
}
