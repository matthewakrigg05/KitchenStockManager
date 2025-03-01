using KitchenStockManager.Models.People;

namespace KitchenStockManager.Models.Inventory
{
    public class RawIngredient : Item
    {
        private string foodGroup;

        public RawIngredient() { }

        public RawIngredient(string itemName, int itemQuantity, string unitType, float itemCost)
            : base(itemName, itemQuantity, unitType, itemCost) { }

        public RawIngredient(string itemName, int itemQuantity, string unitType, float itemCost, Supplier itemSupplier)
            : base(itemName, itemQuantity, unitType, itemCost, itemSupplier) { }

        // Getters and setters - no other methods beyond this point

        public void SetFoodGroup(string group)
        {
            foodGroup = group;
        }

        public string GetFoodGroup()
        {
            return foodGroup;
        }

    }
}
