using KitchenStockManager.Models.People;

namespace KitchenStockManager.Models.Inventory
{
    internal class Item
    {
        private string name { get; set; }
        private int quantity { get; set; }
        private string unit { get; set; }
        private float cost { get; set; }
        private Supplier supplier { get; set; }
    
        public Item()
        {
            name = null;
            quantity = 0;
            unit = null;
            cost = 0;
            supplier = null;
        }

        public Item(string itemName, int itemQuantity, string unitType, float itemCost)
        {
            name = itemName;
            quantity = itemQuantity;
            unit = unitType;
            cost = itemCost;
        }

        public Item(string itemName, int itemQuantity, string unitType, float itemCost, Supplier itemSupplier)
        {
            name = itemName;
            quantity = itemQuantity;
            unit = unitType;
            cost = itemCost;
            supplier = itemSupplier;
        }
    }
}
