using KitchenStockManager.Models.Other;

namespace KitchenStockManager.Models.Inventory
{
    class Menu
    {
        private string menuName {  get; set; }
        private List<Dish> dishes { get; set; }

        public Menu() { }

        public Menu(string name, List<Dish> dish)
        {
            menuName = name;
            dishes = dish;
        }
    }
}
