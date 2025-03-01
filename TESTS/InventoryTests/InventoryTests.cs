using KitchenStockManager.Models.Inventory;
using Xunit;

namespace KitchenStockManager.TESTS.InventoryTests
{
    public class InventoryTests
    {
        [Fact]
        public void AddItem_ShouldAddItemToInventory()
        {
            // Arrange
            var inventory = new Inventory();
            var item = new Item("Apple", 10, "kg");

            // Act
            inventory.AddItem(item);

            // Assert
            Assert.Contains(item, inventory.GetItems());
        }

        [Fact]
        public void RemoveItem_ShouldRemoveItemFromInventory()
        {
            // Arrange
            var inventory = new Inventory();
            var item = new Item("Apple", 10, "kg");
            inventory.AddItem(item);

            // Act
            inventory.RemoveItem(item);

            // Assert
            Assert.DoesNotContain(item, inventory.GetItems());
        }

        [Fact]
        public void GetItem_ShouldReturnCorrectItem()
        {
            // Arrange
            var inventory = new Inventory();
            var item = new Item("Apple", 10, "kg");
            inventory.AddItem(item);

            // Act
            var result = inventory.GetItem("Apple");

            // Assert
            Assert.Equal(item, result);
        }

        [Fact]
        public void ClearInventory_ShouldRemoveAllItems()
        {
            // Arrange
            var inventory = new Inventory();
            var item1 = new Item("Apple", 10, "kg");
            var item2 = new Item("Banana", 5, "kg");
            inventory.AddItem(item1);
            inventory.AddItem(item2);

            // Act
            inventory.clearInventory();

            // Assert
            Assert.Empty(inventory.GetItems());
        }
    }
}

