// <copyright file="Employee.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask
{
    /// <summary>
    /// Model Employee.
    /// </summary>
    public class Employee : IPerson
    {
        private string firstName;
        private string secondName;
        private string thirdName;
        private string position;
        private decimal salary;

        /// <summary>
        /// Gets or sets firstName field.
        /// </summary>
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        /// <summary>
        /// Gets or sets secondName field.
        /// </summary>
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }

        /// <summary>
        /// Gets or sets thirdName field.
        /// </summary>
        public string ThirdName
        {
            get { return this.thirdName; }
            set { this.thirdName = value; }
        }

        /// <summary>
        /// Gets or sets position field.
        /// </summary>
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        /// <summary>
        /// Gets or sets salary field.
        /// </summary>
        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
    }
}
