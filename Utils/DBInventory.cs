using MySql.Data.MySqlClient;
using KitchenStockManager.Models.Inventory;
using Utils;
using Org.BouncyCastle.Cms;

namespace KitchenStockManager.Utils
{
    public static class DBInventory
    {

        public static async void AddItemToDatabase(Item item)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Items (Name, Quantity, Unit, Cost, Supplier) VALUES (@Name, @Quantity, @Unit, @Cost, @Supplier)";
                    cmd.Parameters.AddWithValue("@Name", item.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", item.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", item.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", item.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", item.GetSupplier()?.GetName());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void AddPreparedIngredientToDatabase(PreparedIngredient preparedIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO PreparedIngredients (Name, Quantity, Unit, Cost, Supplier, PreparationInstructions) VALUES (@Name, @Quantity, @Unit, @Cost, @Supplier, @PreparationInstructions)";
                    cmd.Parameters.AddWithValue("@Name", preparedIngredient.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", preparedIngredient.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", preparedIngredient.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", preparedIngredient.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", preparedIngredient.GetSupplier()?.GetName());
                    cmd.Parameters.AddWithValue("@PreparationInstructions", preparedIngredient.GetPreparationInstructions());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void AddRawIngredientToDatabase(RawIngredient rawIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO RawIngredients (Name, Quantity, Unit, Cost, Supplier, FoodGroup) VALUES (@Name, @Quantity, @Unit, @Cost, @Supplier, @FoodGroup)";
                    cmd.Parameters.AddWithValue("@Name", rawIngredient.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", rawIngredient.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", rawIngredient.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", rawIngredient.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", rawIngredient.GetSupplier()?.GetName());
                    cmd.Parameters.AddWithValue("@FoodGroup", rawIngredient.GetFoodGroup());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void RemoveItemFromDatabase(string itemName)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Items WHERE Name = @Name";
                    cmd.Parameters.AddWithValue("@Name", itemName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void RemovePreparedIngredientFromDatabase(string itemName)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM PreparedIngredients WHERE Name = @Name";
                    cmd.Parameters.AddWithValue("@Name", itemName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void RemoveRawIngredientFromDatabase(string itemName)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM RawIngredients WHERE Name = @Name";
                    cmd.Parameters.AddWithValue("@Name", itemName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void UpdateItemInDatabase(Item item)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Items SET Quantity = @Quantity, Unit = @Unit, Cost = @Cost, Supplier = @Supplier WHERE Name = @Name";
                    cmd.Parameters.AddWithValue("@Name", item.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", item.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", item.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", item.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", item.GetSupplier()?.GetName());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void UpdatePreparedIngredientInDatabase(PreparedIngredient preparedIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE PreparedIngredients SET Quantity = @Quantity, Unit = @Unit, Cost = @Cost, Supplier = @Supplier, PreparationInstructions = @PreparationInstructions WHERE Name = @Name";
                    cmd.Parameters.AddWithValue("@Name", preparedIngredient.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", preparedIngredient.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", preparedIngredient.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", preparedIngredient.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", preparedIngredient.GetSupplier()?.GetName());
                    cmd.Parameters.AddWithValue("@PreparationInstructions", preparedIngredient.GetPreparationInstructions());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async void UpdateRawIngredientInDatabase(RawIngredient rawIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "UPDATE RawIngredients SET Quantity = @Quantity, Unit = @Unit, Cost = @Cost, Supplier = @Supplier, FoodGroup = @FoodGroup WHERE Name = @Name";
                    cmd.Parameters.AddWithValue("@Name", rawIngredient.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", rawIngredient.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", rawIngredient.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", rawIngredient.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", rawIngredient.GetSupplier()?.GetName());
                    cmd.Parameters.AddWithValue("@FoodGroup", rawIngredient.GetFoodGroup());

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
