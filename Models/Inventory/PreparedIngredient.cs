namespace KitchenStockManager.Models.Inventory
{
    class PreparedIngredient : Item
    {
        private string preparationInstructions { get; set; }
        private List<RawIngredient> ingredients {  get; set; }
        private List<PreparedIngredient> preparedIngredients { get; set; }

        // need constructors that refer to the item class

        public PreparedIngredient() { }

        public PreparedIngredient(string preparationInstructs, List<RawIngredient> ingreds)
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
            preparedIngredients = preparedIngredients;
        }
    }
}
