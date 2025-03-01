namespace KitchenStockManager.Models.People.Users
{
    public class User
    {
        private string EmailAddress { get; set; }
        private string Password { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Role { get; set; }

        public User() { }

        public User(string email, string pass)
        {
            EmailAddress = email;
            Password = pass;
        }

        public User(string email, string pass, string fname, string lname)
        {
            EmailAddress = email;
            Password = pass;
            FirstName = fname;
            LastName = lname;
        }

        public string getEmail()
        {
            return EmailAddress;
        }

        public string getFirstName()
        {
            return FirstName;
        }

        public string getLastName()
        {
            return LastName;
        }

        public string getRole()
        {
            return Role;

        }

        public string getPassword()
        {
            return Password;
        }
    }
}
