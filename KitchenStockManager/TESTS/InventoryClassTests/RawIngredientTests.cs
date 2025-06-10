using KitchenStockManager.Models.Inventory;
using Xunit;

namespace KitchenStockManager.TESTS.InventoryTests
{
    public class RawIngredientTests
    {
        [Fact]
        public void GetName_ShouldReturnCorrectName()
        {
            // Arrange
            var rawIngredient = new RawIngredient("Tomato", 5, "kg", 2.0f);

            // Act
            var result = rawIngredient.GetName();

            // Assert
            Assert.Equal("Tomato", result);
        }

        [Fact]
        public void GetQuantity_ShouldReturnCorrectQuantity()
        {
            // Arrange
            var rawIngredient = new RawIngredient("Tomato", 5, "kg", 2.0f);

            // Act
            var result = rawIngredient.GetQuantity();

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void GetUnit_ShouldReturnCorrectUnit()
        {
            // Arrange
            var rawIngredient = new RawIngredient("Tomato", 5, "kg", 2.0f);

            // Act
            var result = rawIngredient.GetUnit();

            // Assert
            Assert.Equal("kg", result);
        }

        [Fact]
        public void GetCost_ShouldReturnCorrectCost()
        {
            // Arrange
            var rawIngredient = new RawIngredient("Tomato", 5, "kg", 2.0f);

            // Act
            var result = rawIngredient.GetCost();

            // Assert
            Assert.Equal(2.0f, result);
        }
    }
}

