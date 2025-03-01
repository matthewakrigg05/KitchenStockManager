namespace KitchenStockManager.Models.People.Users
{
    public class User
    {
        private string EmailAddress;
        private string Password;
        private string FirstName;
        private string LastName;
        private string Role;

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
