namespace KitchenStockManager.Models.People
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected string contactNumber;
        protected string emailAddress;

        protected Person() { }

        protected Person(string fname, string lname, string contactNum, string emailAdd)
        {
            firstName = fname;
            lastName = lname;
            contactNumber = contactNum;
            emailAddress = emailAdd;
        }

        protected Person(string fname, string contactNum, string emailAdd)
        {
            firstName = fname;
            contactNumber = contactNum;
            emailAddress = emailAdd;
        }

        public void SetFirstName(string fname)
        {
            firstName = fname;
        }



        public string GetFirstName()
        {
            return firstName;
        }

        public void SetLastName(string lname)
        {
            lastName = lname;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetContactNumber(string contactNum)
        {
            contactNumber = contactNum;
        }

        public string GetContactNumber()
        {
            return contactNumber;
        }

        public void SetEmailAddress(string emailAdd)
        {
            emailAddress = emailAdd;
        }

        public string GetEmailAddress()
        {
            return emailAddress;
        }

        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }

        public string GetContactInfo()
        {
            return $"Contact: {contactNumber} | Email: {emailAddress}";
        }

    }
}
