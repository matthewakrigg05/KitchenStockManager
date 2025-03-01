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

        public void SetEmail(string email)
        {
            EmailAddress = email;
        }

        public string getFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string fname)
        {
            FirstName = fname;
        }

        public string getLastName()
        {
            return LastName;
        }

        public void SetLastName(string lname)
        {
            LastName = lname;
        }

        public string getRole()
        {
            return Role;

        }

        public void SetRole(string role)
        {
            Role = role;
        }

        public string getPassword()
        {
            return Password;
        }

        public void SetPassword(string pass)
        {
            Password = pass;
        }
    }
}
