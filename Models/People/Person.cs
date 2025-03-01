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
    }
}
