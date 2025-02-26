namespace KitchenStockManager.Models.Inventory
{
    class Recipe
    {
        private string instructions {  get; set; }
        private List<PreparedIngredient> preparedIngredients { get; set; }
        private List<RawIngredient> rawIngredients { get; set; }
    
        public Recipe() { }

        public Recipe(string recipeInstructions, List<PreparedIngredient> prepIngreds, List<RawIngredient> rawIngreds)
        {
            instructions = recipeInstructions;
            preparedIngredients = prepIngreds;
            rawIngredients = rawIngreds;
        }

    }
}
