namespace KitchenStockManager.Models.People
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string role;
        private string contactNumber;

        public Person(string firstName, string lastName, string role, string contactNumber)
        {
            setFirstName(firstName);
            setLastName(lastName);
            setRole(role);
            setRole(contactNumber);
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getRole()
        {
            return role;
        }

        public string getContactNumber()
        {
            return contactNumber;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void setRole(string role)
        {
            this.role = role;
        }

        public void setContactNumber(string contactNumber)
        {
            this.contactNumber = contactNumber;
        }
    }
}
