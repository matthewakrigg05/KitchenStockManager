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

        public Dish? GetDish(string dishName)
        {
            foreach (Dish dish in dishes)
            {
                if (dish.GetName() == dishName)
                {
                    return dish;
                }
            }
            return null;
        }

        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        // Getters and setters

        public void SetMenuName(string name)
        {
            menuName = name;
        }

        public string GetMenuName()
        {
            return menuName;
        }

        public List<Dish> GetDishes()
        {
            return dishes;
        }

        public void SetDishes(List<Dish> dish)
        {
            dishes = dish;
        }
    }
}
