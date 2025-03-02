namespace KitchenStockManager.Models.People
{
    class Kitchen
    {
        private List<Staff> staffList;
        private string kitchenName;

        public Kitchen() { }

        public Kitchen(List<Staff> staff, string name)
        {
            kitchenName = name;
            staffList = staff;
        }
    }
}
