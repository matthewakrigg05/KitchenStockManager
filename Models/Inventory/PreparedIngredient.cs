﻿namespace KitchenStockManager.Models.Inventory
{
    public class PreparedIngredient : Item
    {
        private string preparationInstructions;
        private List<RawIngredient> ingredients = new List<RawIngredient>();
        private List<PreparedIngredient> preparedIngredients = new List<PreparedIngredient>();

        public PreparedIngredient() { }

        public PreparedIngredient(string itemName, int itemQuantity, string unitType)
            : base(itemName, itemQuantity, unitType) { }

        public PreparedIngredient(string itemName, int itemQuantity, string unitType, string preparationInstructs)
            : base(itemName, itemQuantity, unitType)
        {
            preparationInstructions = preparationInstructs;
        }

        public void AddRawIngredient(RawIngredient ingredient)
        {
            ingredients.Add(ingredient);
        }

        public void AddPreparedIngredient(PreparedIngredient ingredient)
        {
            preparedIngredients.Add(ingredient);
        }

        public void RemoveRawIngredient(RawIngredient ingredient)
        {
            ingredients.Remove(ingredient);
        }

        public void RemovePreparedIngredient(PreparedIngredient ingredient)
        {
            preparedIngredients.Remove(ingredient);
        }

        // Getters and setters - no other methods beyond this point

        public void SetPreparationInstructions(string preparationInstructs)
        {
            preparationInstructions = preparationInstructs;
        }

        public string GetPreparationInstructions()
        {
            return preparationInstructions;
        }

        public void SetIngredients(List<RawIngredient> ingredientList)
        {
            ingredients = ingredientList;
        }

        public List<RawIngredient> GetIngredients()
        {
            return ingredients;
        }

        public void SetPreparedIngredients(List<PreparedIngredient> preparedIngredientList)
        {
            preparedIngredients = preparedIngredientList;
        }

        public List<PreparedIngredient> GetPreparedIngredients()
        {
            return preparedIngredients;
        }
    }
}
