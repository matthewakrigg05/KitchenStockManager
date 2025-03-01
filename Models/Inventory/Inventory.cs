namespace KitchenStockManager.Models.Inventory
{
    class Inventory
    {
        private List<Item> items;
        private List<PreparedIngredient> preparedIngredients;
        private List<RawIngredient> rawIngredients;

        public Inventory() { }

        public Inventory(List<Item> inventoryItems)
        {
            items = inventoryItems;
        }

        public Item? GetItem(string itemName)
        {
            foreach (Item item in items)
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
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
               items.Remove(item);
            
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

        public void RemoveAllItems() { items.Clear(); }
        public void clearInventory()
        {
            items.Clear();
            preparedIngredients.Clear();
            rawIngredients.Clear();
        }

        // Getters and setters for class variables - no other methods beyond this point

        public List<Item> GetItems() { return items; }

        public void SetItems(List<Item> inventoryItems) 
        { 
            items = inventoryItems; 
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
