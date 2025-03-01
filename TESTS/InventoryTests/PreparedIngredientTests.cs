using KitchenStockManager.Models.Inventory;
using Xunit;

namespace KitchenStockManager.TESTS.InventoryTests
{
    public class PreparedIngredientTests
    {
        [Fact]
        public void GetPreparationInstructions_ShouldReturnCorrectInstructions()
        {
            // Arrange
            var preparedIngredient = new PreparedIngredient("Salad", 1, "bowl", "Chop vegetables and mix");

            // Act
            var result = preparedIngredient.GetPreparationInstructions();

            // Assert
            Assert.Equal("Chop vegetables and mix", result);
        }

        [Fact]
        public void AddPreparedIngredient_ShouldAddIngredient()
        {
            // Arrange
            var preparedIngredient = new PreparedIngredient("Salad", 1, "bowl", "Chop vegetables and mix");
            var ingredient = new PreparedIngredient("Dressing", 1, "cup", "Mix ingredients");

            // Act
            preparedIngredient.AddPreparedIngredient(ingredient);

            // Assert
            Assert.Contains(ingredient, preparedIngredient.GetPreparedIngredients());
        }
    }
}

