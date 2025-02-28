namespace KitchenStockManager.Models.People.Users
{
    internal class User
    {
        private string emailAddress { get; set; }
        private string password { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string role { get; set; }

        public User() { }

        public User(string email, string pass)
        {
            emailAddress = email;
            password = pass;
        }

        public User(string email, string pass, string fname, string lname)
        {
            emailAddress = email;
            password = pass;
            firstName = fname;
            lastName = lname;
        }
    }
}
