namespace KitchenStockManager.Models.Inventory
{
    class Inventory
    {
        private List<Item> items { get; set; }

        public Inventory() { }

        public Inventory(List<Item> inventoryItems)
        {
            items = inventoryItems;
        }
    }
}
