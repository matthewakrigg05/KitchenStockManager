namespace KitchenStockManager.Models.People
{
    internal class User
    {
        private string emailAddress { get; set; }
        private string password { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string role { get; set; }

        public User(string email, string pass)
        {
            emailAddress = email;
            password = pass;
        }

        public User(string pass, string fname, string lname, string emailAdd, string userRole)
        { 
            password = pass;
            firstName = fname;
            lastName = lname;
            emailAddress = emailAdd;
            role = userRole;
        }
    }
}
