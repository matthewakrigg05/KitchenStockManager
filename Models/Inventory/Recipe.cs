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

        public Recipe(string recipeInstructions, List<PreparedIngredient> prepIngreds)
        {
            instructions = recipeInstructions;
            preparedIngredients = prepIngreds;
        }

        public Recipe(string recipeInstructions, List<RawIngredient> rawIngreds)
        {
            instructions = recipeInstructions;
            rawIngredients = rawIngreds;
        }

        public Recipe(string recipeInstructions)
        {
            instructions = recipeInstructions;
        }

        // Getters and setters - no other methods beyond this point

        public void SetInstructions(string recipeInstructions)
        {
            instructions = recipeInstructions;
        }

        public string GetInstructions()
        {
            return instructions;
        }

        public void SetPreparedIngredients(List<PreparedIngredient> prepIngreds)
        {
            preparedIngredients = prepIngreds;
        }

        public List<PreparedIngredient> GetPreparedIngredients()
        {
            return preparedIngredients;
        }

        public void SetRawIngredients(List<RawIngredient> rawIngreds)
        {
            rawIngredients = rawIngreds;
        }

        public List<RawIngredient> GetRawIngredients()
        {
            return rawIngredients;
        }
    }
}
