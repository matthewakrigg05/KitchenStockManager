using KitchenStockManager.Models.People;

namespace KitchenStockManager.Models.Inventory
{
    public class Item
    {
        private string name;
        private int quantity;
        private string unit;
        private float cost;
        private Supplier supplier;

        public Item() { }

        public Item(string itemName, int itemQuantity, string unitType)
        {
            name = itemName;
            quantity = itemQuantity;
            unit = unitType;
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

        // Getters and setters - no other methods beyond this point

        public void SetName(string itemName)
        {
            name = itemName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetQuantity(int itemQuantity)
        {
            quantity = itemQuantity;
        }

        public int GetQuantity() 
        { 
            return quantity; 
        }

        public void SetUnit(string unitType)
        {
            unit = unitType;
        }

        public string GetUnit() 
        { 
            return unit; 
        }

        public void SetCost(float itemCost)
        {
            cost = itemCost;
        }

        public float GetCost() 
        {
            return cost; 
        }

        public void SetSupplier(Supplier itemSupplier)
        {
            supplier = itemSupplier;
        }

        public Supplier GetSupplier() 
        { 
            return supplier;
        }


    }
}
