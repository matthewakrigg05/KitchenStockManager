using System.Collections.Generic;
using KitchenStockManager.Models.Inventory;
using Xunit;

namespace KitchenStockManager.Tests.Models.Inventory
{
    public class RecipeTests
    {
        [Fact]
        public void Test_SetInstructions()
        {
            // Arrange
            var recipe = new Recipe();
            var instructions = "Mix all ingredients.";

            // Act
            recipe.SetInstructions(instructions);

            // Assert
            Assert.Equal(instructions, recipe.GetInstructions());
        }

        [Fact]
        public void Test_SetPreparedIngredients()
        {
            // Arrange
            var recipe = new Recipe();
            var preparedIngredients = new List<PreparedIngredient>
            {
                new PreparedIngredient("Chopped Onions", 1, "cup"),
                new PreparedIngredient("Grated Cheese", 2, "cups")
            };

            // Act
            recipe.SetPreparedIngredients(preparedIngredients);

            // Assert
            Assert.Equal(preparedIngredients, recipe.GetPreparedIngredients());
        }

        [Fact]
        public void Test_SetRawIngredients()
        {
            // Arrange
            var recipe = new Recipe();
            var rawIngredients = new List<RawIngredient>
            {
                new RawIngredient("Tomato", 3, "pieces", 1.5f),
                new RawIngredient("Salt", 1, "tsp", 0.1f)
            };

            // Act
            recipe.SetRawIngredients(rawIngredients);

            // Assert
            Assert.Equal(rawIngredients, recipe.GetRawIngredients());
        }

        [Fact]
        public void Test_RecipeConstructor_WithAllParameters()
        {
            // Arrange
            var instructions = "Mix all ingredients.";
            var preparedIngredients = new List<PreparedIngredient>
            {
                new PreparedIngredient("Chopped Onions", 1, "cup")
            };
            var rawIngredients = new List<RawIngredient>
            {
                new RawIngredient("Tomato", 3, "pieces", 1.5f)
            };

            // Act
            var recipe = new Recipe(instructions, preparedIngredients, rawIngredients);

            // Assert
            Assert.Equal(instructions, recipe.GetInstructions());
            Assert.Equal(preparedIngredients, recipe.GetPreparedIngredients());
            Assert.Equal(rawIngredients, recipe.GetRawIngredients());
        }

        [Fact]
        public void Test_RecipeConstructor_WithPreparedIngredients()
        {
            // Arrange
            var instructions = "Mix all ingredients.";
            var preparedIngredients = new List<PreparedIngredient>
            {
                new PreparedIngredient("Chopped Onions", 1, "cup")
            };

            // Act
            var recipe = new Recipe(instructions, preparedIngredients);

            // Assert
            Assert.Equal(instructions, recipe.GetInstructions());
            Assert.Equal(preparedIngredients, recipe.GetPreparedIngredients());
        }

        [Fact]
        public void Test_RecipeConstructor_WithRawIngredients()
        {
            // Arrange
            var instructions = "Mix all ingredients.";
            var rawIngredients = new List<RawIngredient>
            {
                new RawIngredient("Tomato", 3, "pieces", 1.5f)
            };

            // Act
            var recipe = new Recipe(instructions, rawIngredients);

            // Assert
            Assert.Equal(instructions, recipe.GetInstructions());
            Assert.Equal(rawIngredients, recipe.GetRawIngredients());
        }

        [Fact]
        public void Test_RecipeConstructor_WithInstructionsOnly()
        {
            // Arrange
            var instructions = "Mix all ingredients.";

            // Act
            var recipe = new Recipe(instructions);

            // Assert
            Assert.Equal(instructions, recipe.GetInstructions());
        }
    }
}
