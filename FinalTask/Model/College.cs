namespace FinalTask.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Model College.
    /// </summary>
    public class College
    {
        private string title;
        private string address;
        private List<Employee> employees;
        private List<Student> students;

        /// <summary>
        /// Initializes a new instance of the <see cref="College"/> class.
        /// Initializes List Employee/> class.
        /// Initializes List Student/> class.
        /// </summary>
        public College()
        {
            this.employees = new List<Employee>();
            this.students = new List<Student>();
        }

        /// <summary>
        /// Gets or sets title field.
        /// </summary>
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        /// <summary>
        /// Gets or sets address field.
        /// </summary>
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        /// <summary>
        /// Gets or sets employees field.
        /// </summary>
        public List<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        /// <summary>
        /// Gets or sets students field.
        /// </summary>
        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
    }
}
