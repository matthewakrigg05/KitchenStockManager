using KitchenStockManager.Models.Inventory;
using Xunit;

namespace KitchenStockManager.TESTS.InventoryTests
{
    public class ItemTests
    {
        [Fact]
        public void GetName_ShouldReturnCorrectName()
        {
            // Arrange
            var item = new Item("Apple", 10, "kg");

            // Act
            var result = item.GetName();

            // Assert
            Assert.Equal("Apple", result);
        }

        [Fact]
        public void GetQuantity_ShouldReturnCorrectQuantity()
        {
            // Arrange
            var item = new Item("Apple", 10, "kg");

            // Act
            var result = item.GetQuantity();

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void GetUnit_ShouldReturnCorrectUnit()
        {
            // Arrange
            var item = new Item("Apple", 10, "kg");

            // Act
            var result = item.GetUnit();

            // Assert
            Assert.Equal("kg", result);
        }

        [Fact]
        public void SetCost_ShouldUpdateCost()
        {
            // Arrange
            var item = new Item("Apple", 10, "kg");
            item.SetCost(5.0f);

            // Act
            var result = item.GetCost();

            // Assert
            Assert.Equal(5.0f, result);
        }
    }
}

