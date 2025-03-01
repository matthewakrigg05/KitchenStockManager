namespace KitchenStockManager.Models.Inventory
{
    class Inventory
    {
        private List<Item> inventoryItems = new List<Item>();
        private List<PreparedIngredient> preparedIngredients = new List<PreparedIngredient>();
        private List<RawIngredient> rawIngredients = new List<RawIngredient>();

        public Inventory() { }

        public Inventory(List<Item> items)
        {
            inventoryItems = items;
        }

        public Item? GetItem(string itemName)
        {
            foreach (Item item in inventoryItems)
            {
                if (item.GetName() == itemName)
                {
                    return item;
                }
            }
            return null;
        }

        public void AddItem(Item item)
        {
            inventoryItems.Add(item);
        }

        public void RemoveItem(Item item)
        {
               inventoryItems.Remove(item);
            
        }

        public void AddPreparedIngredient(PreparedIngredient preparedIngredient)
        {
            preparedIngredients.Add(preparedIngredient);
        }

        public void RemovePreparedIngredient(PreparedIngredient preparedIngredient)
        {
            preparedIngredients.Remove(preparedIngredient);
        }

        public void AddRawIngredient(RawIngredient rawIngredient)
        {
            rawIngredients.Add(rawIngredient);
        }

        public void RemoveRawIngredient(RawIngredient rawIngredient)
        {
            rawIngredients.Remove(rawIngredient);
        }

        public void RemoveAllItems() { inventoryItems.Clear(); }
        public void clearInventory()
        {
            inventoryItems.Clear();
            preparedIngredients.Clear();
            rawIngredients.Clear();
        }

        // Getters and setters for class variables - no other methods beyond this point

        public List<Item> GetItems() { return inventoryItems; }

        public void SetItems(List<Item> inventoryItems) 
        { 
            this.inventoryItems = inventoryItems; 
        }

        public List<PreparedIngredient> GetPreparedIngredients() { return preparedIngredients; }

        public void SetPreparedIngredients(List<PreparedIngredient> prepIngreds)
        {
            preparedIngredients = prepIngreds;
        }

        public List<RawIngredient> GetRawIngredients() { return rawIngredients; }

        public void SetRawIngredients(List<RawIngredient> rawIngreds)
        {
            rawIngredients = rawIngreds;
        }
    }
}
