using KitchenStockManager.Models.People;

namespace KitchenStockManager.Models.Inventory
{
    class RawIngredient : Item
    {
        public RawIngredient() { }

        public RawIngredient(string itemName, int itemQuantity, string unitType, float itemCost)
            : base(itemName, itemQuantity, unitType, itemCost) { }

        public RawIngredient(string itemName, int itemQuantity, string unitType, float itemCost, Supplier itemSupplier)
            : base(itemName, itemQuantity, unitType, itemCost, itemSupplier) { }

    }
}
