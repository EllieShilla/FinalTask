namespace FinalTask
{
    public class Employee : IPerson
    {
        string firstName;
        string secondName;
        string thirdName;
        string position;
        decimal salary;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string ThirdName
        {
            get { return thirdName; }
            set { thirdName = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
