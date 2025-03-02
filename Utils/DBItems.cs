using MySql.Data.MySqlClient;
using KitchenStockManager.Models.Inventory;
using System;
using Utils;

namespace KitchenStockManager.Utils
{
    public class InventoryDbTests
    {

        public async void AddItemToDatabase(Item item)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "INSERT INTO Items (Name, Quantity, Unit, Cost, Supplier) VALUES (@Name, @Quantity, @Unit, @Cost, @Supplier)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", item.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", item.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", item.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", item.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", item.GetSupplier()?.GetName());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public async void AddPreparedIngredientToDatabase(PreparedIngredient preparedIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO PreparedIngredients (Name, Quantity, Unit, Cost, Supplier, PreparationInstructions) VALUES (@Name, @Quantity, @Unit, @Cost, @Supplier, @PreparationInstructions)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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

        public async void AddRawIngredientToDatabase(RawIngredient rawIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO RawIngredients (Name, Quantity, Unit, Cost, Supplier, FoodGroup) VALUES (@Name, @Quantity, @Unit, @Cost, @Supplier, @FoodGroup)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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

        public async void RemoveItemFromDatabase(string itemName)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "DELETE FROM Items WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", itemName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public async void RemovePreparedIngredientFromDatabase(string itemName)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "DELETE FROM PreparedIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", itemName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public async void RemoveRawIngredientFromDatabase(string itemName)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "DELETE FROM RawIngredients WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", itemName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public async void UpdateItemInDatabase(Item item)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "UPDATE Items SET Quantity = @Quantity, Unit = @Unit, Cost = @Cost, Supplier = @Supplier WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", item.GetName());
                    cmd.Parameters.AddWithValue("@Quantity", item.GetQuantity());
                    cmd.Parameters.AddWithValue("@Unit", item.GetUnit());
                    cmd.Parameters.AddWithValue("@Cost", item.GetCost());
                    cmd.Parameters.AddWithValue("@Supplier", item.GetSupplier()?.GetName());

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public async void UpdatePreparedIngredientInDatabase(PreparedIngredient preparedIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "UPDATE PreparedIngredients SET Quantity = @Quantity, Unit = @Unit, Cost = @Cost, Supplier = @Supplier, PreparationInstructions = @PreparationInstructions WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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

        public async void UpdateRawIngredientInDatabase(RawIngredient rawIngredient)
        {
            using (var conn = await DBHelper.GetConnection())
            {
                string query = "UPDATE RawIngredients SET Quantity = @Quantity, Unit = @Unit, Cost = @Cost, Supplier = @Supplier, FoodGroup = @FoodGroup WHERE Name = @Name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
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
