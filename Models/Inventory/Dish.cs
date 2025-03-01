namespace KitchenStockManager.Models.Inventory
{
    class Dish
    {
        private string name;
        private List<RawIngredient> rawIngredients;
        private List<PreparedIngredient> preparedIngredients;
        private string description;
        private string type;

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

        public void SetName(string dishName)
        {
            name = dishName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
