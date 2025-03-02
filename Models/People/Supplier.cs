namespace KitchenStockManager.Models.People
{
    public class Supplier : Person
    {
        public Supplier() { }

        public Supplier(string firstName, string contactNumber, string email) 
            : base(firstName, contactNumber, email) { }
    }
}
