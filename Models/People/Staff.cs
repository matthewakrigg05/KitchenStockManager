﻿namespace KitchenStockManager.Models.People
{
    class Staff : Person
    {
        private string staffRole;

        public Staff() { }

        public Staff(string firstName, string lastName, string role, string contactNumber, string email) 
            : base(firstName, lastName, contactNumber, email)
        {
            staffRole = role;
        }
    }
}
