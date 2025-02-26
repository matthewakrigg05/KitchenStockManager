namespace KitchenStockManager.Models.People
{
    class Supplier : Person
    {
        public Supplier() { }

        public Supplier(string firstName, string lastName, string contactNumber, string email) 
            : base(firstName, lastName, contactNumber, email) { }
    }
}
