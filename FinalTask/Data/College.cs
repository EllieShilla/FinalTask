using System.Collections.Generic;

namespace FinalTask.Data
{
    public class College
    {
        string title;
        string address;
        List<Employee> employees;
        List<Student> students;

        public College()
        {
            employees = new List<Employee>();
            students = new List<Student>();
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
    }
}
