namespace KitchenStockManager.Models.Inventory
{
    public class PreparedIngredient : Item
    {
        private string preparationInstructions;
        private List<RawIngredient> ingredients;
        private List<PreparedIngredient> preparedIngredients;

        public PreparedIngredient() { }

        public PreparedIngredient(string itemName, int itemQuantity, string unitType)
            : base(itemName, itemQuantity, unitType) { }

        public PreparedIngredient(string itemName, int itemQuantity, string unitType, string preparationInstructs, List<RawIngredient> ingreds)
            : base(itemName, itemQuantity, unitType)
        {
            preparationInstructions = preparationInstructs;
            ingredients = ingreds;
        }

        public PreparedIngredient(string preparationInstructs, List<PreparedIngredient> ingreds)
        {
            preparationInstructions = preparationInstructs;
            preparedIngredients = ingreds;
        }

        public PreparedIngredient(string preparationInstructs, List<RawIngredient> ingreds, List<PreparedIngredient> preparedIngreds)
        {
            preparationInstructions = preparationInstructs;
            ingredients = ingreds;
            preparedIngredients = preparedIngreds;
        }
    }
}
