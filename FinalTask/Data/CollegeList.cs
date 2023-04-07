// <copyright file="CollegeList.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask.Data
{
    using System.Collections.Generic;

    /// <summary>
    /// Class CollegeList for deserialization from json file.
    /// </summary>
    public class CollegeList
    {
        /// <summary>
        /// Gets or sets list of College.
        /// </summary>
        public List<College> Colleges { get; set; }
    }
}
