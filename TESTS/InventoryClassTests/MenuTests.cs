using System.Collections.Generic;
using KitchenStockManager.Models.Inventory;
using Xunit;

namespace KitchenStockManager.Tests.Models.Inventory
{
    public class MenuTests
    {
        [Fact]
        public void Constructor_ShouldInitializeMenuNameAndDishes()
        {
            // Arrange
            var dish1 = new Dish("Dish1");
            var dish2 = new Dish("Dish2");
            var dishes = new List<Dish> { dish1, dish2 };
            var menuName = "Test Menu";

            // Act
            var menu = new Menu(menuName, dishes);

            // Assert
            Assert.Equal(menuName, menu.GetMenuName());
            Assert.Equal(dishes, menu.GetDishes());
        }

        [Fact]
        public void GetDish_ShouldReturnCorrectDish()
        {
            // Arrange
            var dish1 = new Dish("Dish1");
            var dish2 = new Dish("Dish2");
            var dishes = new List<Dish> { dish1, dish2 };
            var menu = new Menu("Test Menu", dishes);

            // Act
            var result = menu.GetDish("Dish1");

            // Assert
            Assert.Equal(dish1, result);
        }

        [Fact]
        public void GetDish_ShouldReturnNullIfDishNotFound()
        {
            // Arrange
            var dish1 = new Dish("Dish1");
            var dish2 = new Dish("Dish2");
            var dishes = new List<Dish> { dish1, dish2 };
            var menu = new Menu("Test Menu", dishes);

            // Act
            var result = menu.GetDish("Dish3");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void AddDish_ShouldAddDishToMenu()
        {
            // Arrange
            var dish1 = new Dish("Dish1");
            var dishes = new List<Dish> { dish1 };
            var menu = new Menu("Test Menu", dishes);
            var newDish = new Dish("Dish2");

            // Act
            menu.AddDish(newDish);

            // Assert
            Assert.Contains(newDish, menu.GetDishes());
        }

        [Fact]
        public void RemoveDish_ShouldRemoveDishFromMenu()
        {
            // Arrange
            var dish1 = new Dish("Dish1");
            var dish2 = new Dish("Dish2");
            var dishes = new List<Dish> { dish1, dish2 };
            var menu = new Menu("Test Menu", dishes);

            // Act
            menu.RemoveDish(dish1);

            // Assert
            Assert.DoesNotContain(dish1, menu.GetDishes());
        }

        [Fact]
        public void SetMenuName_ShouldUpdateMenuName()
        {
            // Arrange
            var menu = new Menu("Old Menu", new List<Dish>());

            // Act
            menu.SetMenuName("New Menu");

            // Assert
            Assert.Equal("New Menu", menu.GetMenuName());
        }

        [Fact]
        public void SetDishes_ShouldUpdateDishes()
        {
            // Arrange
            var menu = new Menu("Test Menu", new List<Dish>());
            var newDishes = new List<Dish> { new Dish("Dish1"), new Dish("Dish2") };

            // Act
            menu.SetDishes(newDishes);

            // Assert
            Assert.Equal(newDishes, menu.GetDishes());
        }
    }
}
