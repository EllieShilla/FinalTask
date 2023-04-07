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
