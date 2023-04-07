// <copyright file="SpecializeDto.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask.Dto
{
    /// <summary>
    /// Class SpecializeDto for writing data into file.
    /// </summary>
    public class SpecializeDto
    {
        private string specialization;
        private int count;
        private string title;

        /// <summary>
        /// Gets or sets specialization field.
        /// </summary>
        public string Specialization
        {
            get { return this.specialization; }
            set { this.specialization = value; }
        }

        /// <summary>
        /// Gets or sets count field.
        /// </summary>
        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }

        /// <summary>
        /// Gets or sets title field.
        /// </summary>
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
    }
}
