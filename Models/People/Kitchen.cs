﻿namespace KitchenStockManager.Models.People
{
    class Kitchen
    {
        private List<Staff> staffList { get; set; }
        private string kitchenName { get; set; }

        public Kitchen() { }

        public Kitchen(List<Staff> staff, string name)
        {
            kitchenName = name;
            staffList = staff;
        }
    }
}
