namespace KitchenStockManager.Models.Inventory
{
    class Dish
    {
        private string name {  get; set; }
        private List<RawIngredient> rawIngredients {  get; set; }
        private List<PreparedIngredient> preparedIngredients { get; set; }
        private string description {  get; set; }
        private string type { get; set; }

        public Dish() { }

        public Dish(string dishName)
        {
            name = dishName;
        }

        public Dish(string dishName, string dishDesc)
        {
            name = dishName;
            description = dishDesc;
        }

        public Dish(string dishName, string dishDesc, List<RawIngredient> rawIngreds, List<PreparedIngredient> preparedIngreds)
        {
            name = dishName;
            description = dishDesc;
            rawIngredients = rawIngreds;
            preparedIngredients = preparedIngreds;
        }

        public Dish(string dishName, string dishDesc, List<RawIngredient> rawIngreds, List<PreparedIngredient> preparedIngreds, string dishType)
        {
            name = dishName;
            description = dishDesc;
            rawIngredients = rawIngreds;
            preparedIngredients = preparedIngreds;
            type = dishType;
        }
    }
}
