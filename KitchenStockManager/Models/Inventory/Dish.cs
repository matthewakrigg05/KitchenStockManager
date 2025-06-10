namespace KitchenStockManager.Models.Inventory
{
    class Dish
    {
        private string name;
        private List<RawIngredient> rawIngredients;
        private List<PreparedIngredient> preparedIngredients;
        private string description;
        private string type;
        private string instructions;

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


        // Getters and setters - not other methods beyond this point

        public void SetName(string dishName)
        {
            name = dishName;
        }

        public string GetName()
        {
            return name;
        }

        public void SetDescription(string dishDesc)
        {
            description = dishDesc;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetRawIngredients(List<RawIngredient> rawIngreds)
        {
            rawIngredients = rawIngreds;
        }

        public List<RawIngredient> GetRawIngredients()
        {
            return rawIngredients;
        }

        public void SetPreparedIngredients(List<PreparedIngredient> preparedIngreds)
        {
            preparedIngredients = preparedIngreds;
        }

        public List<PreparedIngredient> GetPreparedIngredients()
        {
            return preparedIngredients;
        }

        public void SetType(string dishType)
        {
            type = dishType;

        }

        public string GetDishType()
        {
            return type;
        }

        public void SetInstructions(string dishInstructions)
        {
            instructions = dishInstructions;
        }

        public string GetInstructions()
        {
            return instructions;
        }
    }
}
