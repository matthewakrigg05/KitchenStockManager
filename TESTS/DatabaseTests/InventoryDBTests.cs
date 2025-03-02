using KitchenStockManager.Models.Inventory;
using MySql.Data.MySqlClient;
using Utils.DBInventory;
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
            await DBItems.AddItemToDatabase(item);

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
            await DBInventory.AddItemToDatabase(item);

            // Act
            await DBInventory.RemoveItemFromDatabase(item.GetName());

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
            await _dbUtils.AddItemToDatabase(item);
            item.SetQuantity(20);

            // Act
            await _dbUtils.UpdateItemInDatabase(item);

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
            await _dbUtils.AddPreparedIngredientToDatabase(preparedIngredient);

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
            await _dbUtils.AddPreparedIngredientToDatabase(preparedIngredient);

            // Act
            await _dbUtils.RemovePreparedIngredientFromDatabase(preparedIngredient.GetName());

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
            await _dbUtils.AddPreparedIngredientToDatabase(preparedIngredient);
            preparedIngredient.SetQuantity(10);

            // Act
            await _dbUtils.UpdatePreparedIngredientInDatabase(preparedIngredient);

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
            await _dbUtils.AddRawIngredientToDatabase(rawIngredient);

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
            await _dbUtils.AddRawIngredientToDatabase(rawIngredient);

            // Act
            await _dbUtils.RemoveRawIngredientFromDatabase(rawIngredient.GetName());

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
            await _dbUtils.AddRawIngredientToDatabase(rawIngredient);
            rawIngredient.SetQuantity(100);

            // Act
            await _dbUtils.UpdateRawIngredientInDatabase(rawIngredient);

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
