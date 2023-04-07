using System.Collections.Generic;

namespace FinalTask
{
    public class Student : IPerson
    {
        string firstName;
        string secondName;
        string thirdName;
        string group;
        string specialization;

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
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public string Specialization
        {
            get { return specialization; }
            set { specialization = value; }
        }
    }
}
