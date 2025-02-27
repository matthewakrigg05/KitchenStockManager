namespace KitchenStockManager.Models.People
{
    class KitchenMember : Staff
    {
        private string kitchenRole { get; set; }

        public KitchenMember() { }

        public KitchenMember(string firstName, string lastName, string role, string contactNumber, string email, string memberRole)
            : base(firstName, lastName, role, contactNumber, email)
        {
            kitchenRole = memberRole;
        }
    }
}
