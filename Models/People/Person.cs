namespace KitchenStockManager.Models.People
{
    class Person
    {
        protected string firstName { get; set; }
        protected string lastName { get; set; }
        protected string contactNumber { get; set; }
        protected string emailAddress { get; set; }

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
