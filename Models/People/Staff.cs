namespace KitchenStockManager.Models.People
{
    class Staff : Person
    {
        private string staffRole { get; set; }
        private string contactNumber { get; set; }

        public Staff() { }

        public Staff(string firstName, string lastName, string role, string contactNumber) 
            : base(firstName, lastName, contactNumber)
        {
            staffRole = role;
        }
    }
}
