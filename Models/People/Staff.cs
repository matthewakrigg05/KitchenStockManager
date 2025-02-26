namespace KitchenStockManager.Models.People
{
    class Staff : Person
    {
        private string staffRole { get; set; }
        private string contactNumber { get; set; }

        public Staff() 
            : base("N/A", "N/A", "N/A")
        {
            staffRole = "N/A";
        }

        public Staff(string firstName, string lastName, string role, string contactNumber) 
            : base(firstName, lastName, contactNumber)
        {
            staffRole = role;
        }
    }
}
