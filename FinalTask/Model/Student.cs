// <copyright file="Student.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask
{
    /// <summary>
    /// Model Student.
    /// </summary>
    public class Student : IPerson
    {
        private string firstName;
        private string secondName;
        private string thirdName;
        private string group;
        private string specialization;

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
        /// Gets or sets group field.
        /// </summary>
        public string Group
        {
            get { return this.group; }
            set { this.group = value; }
        }

        /// <summary>
        /// Gets or sets specialization field.
        /// </summary>
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }
    }
}
