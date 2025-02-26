namespace KitchenStockManager.Models.Inventory
{
    class PreparedIngredient : Item
    {
        private string preparationInstructions { get; set; }
        private List<RawIngredient> ingredients {  get; set; }

        public PreparedIngredient() { }

        public PreparedIngredient(string preparationInstructs, List<RawIngredient> ingreds)
        {
            preparationInstructions = preparationInstructs;
            ingredients = ingreds;
        }
    }
}
