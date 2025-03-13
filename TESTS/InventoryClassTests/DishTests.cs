using KitchenStockManager.Models.Inventory;
using Xunit;

namespace KitchenStockManager.TESTS.InventoryTests
{
    class DishTests
    {
        [Fact]
        public void Test_SetName()
        {
            var dish = new Dish();
            dish.SetName("Pasta");
            Assert.Equal("Pasta", dish.GetName());
        }

        [Fact]
        public void Test_SetDescription()
        {
            var dish = new Dish();
            dish.SetDescription("Delicious pasta with tomato sauce");
            Assert.Equal("Delicious pasta with tomato sauce", dish.GetDescription());
        }

        [Fact]
        public void Test_SetRawIngredients()
        {
            var rawIngredients = new List<RawIngredient>
            {
                new RawIngredient("Tomato", 2, "pcs", 1.5f),
                new RawIngredient("Pasta", 1, "pack", 2.0f)
            };
            var dish = new Dish();
            dish.SetRawIngredients(rawIngredients);
            Assert.Equal(rawIngredients, dish.GetRawIngredients());
        }

        [Fact]
        public void Test_SetPreparedIngredients()
        {
            var preparedIngredients = new List<PreparedIngredient>
            {
                new PreparedIngredient("Tomato Sauce", 1, "bottle"),
                new PreparedIngredient("Cheese", 1, "pack")
            };
            var dish = new Dish();
            dish.SetPreparedIngredients(preparedIngredients);
            Assert.Equal(preparedIngredients, dish.GetPreparedIngredients());
        }

        [Fact]
        public void Test_SetType()
        {
            var dish = new Dish();
            dish.SetType("Main Course");
            Assert.Equal("Main Course", dish.GetDishType());
        }

        [Fact]
        public void Test_SetInstructions()
        {
            var dish = new Dish();
            dish.SetInstructions("Boil pasta, add sauce, mix well.");
            Assert.Equal("Boil pasta, add sauce, mix well.", dish.GetInstructions());
        }

        [Fact]
        public void Test_Constructor_WithName()
        {
            var dish = new Dish("Pasta");
            Assert.Equal("Pasta", dish.GetName());
        }

        [Fact]
        public void Test_Constructor_WithNameAndDescription()
        {
            var dish = new Dish("Pasta", "Delicious pasta with tomato sauce");
            Assert.Equal("Pasta", dish.GetName());
            Assert.Equal("Delicious pasta with tomato sauce", dish.GetDescription());
        }

        [Fact]
        public void Test_Constructor_WithNameDescriptionAndIngredients()
        {
            var rawIngredients = new List<RawIngredient>
            {
                new RawIngredient("Tomato", 2, "pcs", 1.5f),
                new RawIngredient("Pasta", 1, "pack", 2.0f)
            };
            var preparedIngredients = new List<PreparedIngredient>
            {
                new PreparedIngredient("Tomato Sauce", 1, "bottle"),
                new PreparedIngredient("Cheese", 1, "pack")
            };
            var dish = new Dish("Pasta", "Delicious pasta with tomato sauce", rawIngredients, preparedIngredients);
            Assert.Equal("Pasta", dish.GetName());
            Assert.Equal("Delicious pasta with tomato sauce", dish.GetDescription());
            Assert.Equal(rawIngredients, dish.GetRawIngredients());
            Assert.Equal(preparedIngredients, dish.GetPreparedIngredients());
        }

        [Fact]
        public void Test_Constructor_WithAllParameters()
        {
            var rawIngredients = new List<RawIngredient>
            {
                new RawIngredient("Tomato", 2, "pcs", 1.5f),
                new RawIngredient("Pasta", 1, "pack", 2.0f)
            };
            var preparedIngredients = new List<PreparedIngredient>
            {
                new PreparedIngredient("Tomato Sauce", 1, "bottle"),
                new PreparedIngredient("Cheese", 1, "pack")
            };
            var dish = new Dish("Pasta", "Delicious pasta with tomato sauce", rawIngredients, preparedIngredients, "Main Course");
            Assert.Equal("Pasta", dish.GetName());
            Assert.Equal("Delicious pasta with tomato sauce", dish.GetDescription());
            Assert.Equal(rawIngredients, dish.GetRawIngredients());
            Assert.Equal(preparedIngredients, dish.GetPreparedIngredients());
            Assert.Equal("Main Course", dish.GetDishType());
        }

    }
}
