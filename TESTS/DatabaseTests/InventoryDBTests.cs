using KitchenStockManager.Models.Inventory;
using KitchenStockManager.Utils;
using MySql.Data.MySqlClient;
using Utils;
using Xunit;

namespace KitchenStockManager.TESTS
{
    public class InventoryDbTests
    {

        [Fact]
        public async Task AddItemToDatabase_ShouldAddItem()
        {
            // Arrange
            var item = new Item("Apple", 10, "kg");

            // Act
            DBInventory.AddItemToDatabase(item);

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Items WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", item.GetName());
                    var count = (long)cmd.ExecuteScalar();
                    Assert.Equal(1, count);
                }
            }
        }

        [Fact]
        public async Task RemoveItemFromDatabase_ShouldRemoveItem()
        {
            // Arrange
            var item = new Item("Apple", 10, "kg");
            DBInventory.AddItemToDatabase(item);

            // Act
            DBInventory.RemoveItemFromDatabase(item.GetName());

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Items WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", item.GetName());
                    var count = (long)cmd.ExecuteScalar();
                    Assert.Equal(0, count);
                }
            }
        }

        [Fact]
        public async Task UpdateItemInDatabase_ShouldUpdateItem()
        {
            // Arrange
            var item = new Item("Apple", 10, "kg");
            DBInventory.AddItemToDatabase(item);
            item.SetQuantity(20);

            // Act
            DBInventory.UpdateItemInDatabase(item);

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT Quantity FROM Items WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", item.GetName());
                    var quantity = (int)cmd.ExecuteScalar();
                    Assert.Equal(20, quantity);
                }
            }
        }

        [Fact]
        public async Task AddPreparedIngredientToDatabase_ShouldAddPreparedIngredient()
        {
            // Arrange
            var preparedIngredient = new PreparedIngredient("Apple Pie", 5, "pcs", "Bake at 350 degrees for 45 minutes");

            // Act
            DBInventory.AddPreparedIngredientToDatabase(preparedIngredient);

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM PreparedIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", preparedIngredient.GetName());
                    var count = (long)cmd.ExecuteScalar();
                    Assert.Equal(1, count);
                }
            }
        }

        [Fact]
        public async Task RemovePreparedIngredientFromDatabase_ShouldRemovePreparedIngredient()
        {
            // Arrange
            var preparedIngredient = new PreparedIngredient("Apple Pie", 5, "pcs", "Bake at 350 degrees for 45 minutes");
            DBInventory.AddPreparedIngredientToDatabase(preparedIngredient);

            // Act
            DBInventory.RemovePreparedIngredientFromDatabase(preparedIngredient.GetName());

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM PreparedIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", preparedIngredient.GetName());
                    var count = (long)cmd.ExecuteScalar();
                    Assert.Equal(0, count);
                }
            }
        }

        [Fact]
        public async Task UpdatePreparedIngredientInDatabase_ShouldUpdatePreparedIngredient()
        {
            // Arrange
            var preparedIngredient = new PreparedIngredient("Apple Pie", 5, "pcs", "Bake at 350 degrees for 45 minutes");
            DBInventory.AddPreparedIngredientToDatabase(preparedIngredient);
            preparedIngredient.SetQuantity(10);

            // Act
            DBInventory.UpdatePreparedIngredientInDatabase(preparedIngredient);

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT Quantity FROM PreparedIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", preparedIngredient.GetName());
                    var quantity = (int)cmd.ExecuteScalar();
                    Assert.Equal(10, quantity);
                }
            }
        }

        [Fact]
        public async Task AddRawIngredientToDatabase_ShouldAddRawIngredient()
        {
            // Arrange
            var rawIngredient = new RawIngredient("Flour", 50, "kg", 20.0f);

            // Act
            DBInventory.AddRawIngredientToDatabase(rawIngredient);

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM RawIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", rawIngredient.GetName());
                    var count = (long)cmd.ExecuteScalar();
                    Assert.Equal(1, count);
                }
            }
        }

        [Fact]
        public async Task RemoveRawIngredientFromDatabase_ShouldRemoveRawIngredient()
        {
            // Arrange
            var rawIngredient = new RawIngredient("Flour", 50, "kg", 20.0f);
            DBInventory.AddRawIngredientToDatabase(rawIngredient);

            // Act
            DBInventory.RemoveRawIngredientFromDatabase(rawIngredient.GetName());

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM RawIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", rawIngredient.GetName());
                    var count = (long)cmd.ExecuteScalar();
                    Assert.Equal(0, count);
                }
            }
        }

        [Fact]
        public async Task UpdateRawIngredientInDatabase_ShouldUpdateRawIngredient()
        {
            // Arrange
            var rawIngredient = new RawIngredient("Flour", 50, "kg", 20.0f);
            DBInventory.AddRawIngredientToDatabase(rawIngredient);
            rawIngredient.SetQuantity(100);

            // Act
            DBInventory.UpdateRawIngredientInDatabase(rawIngredient);

            // Assert
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "SELECT Quantity FROM RawIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", rawIngredient.GetName());
                    var quantity = (int)cmd.ExecuteScalar();
                    Assert.Equal(100, quantity);
                }
            }
        }
    }
}
