namespace FinalTask.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using FinalTask.Dto;

    /// <summary>
    /// Class DataProcessor for process data that we got from file.
    /// </summary>
    public class DataProcessor
    {
        /// <summary>
        /// Return list of SpezializeDto for saving in file.
        /// </summary>
        /// <param name="colleges">The list of Colleges for grouping by student specializations.</param>
        /// <returns>List of SpezializeDto, representing list that grouping by student specializations.</returns>
        public static List<SpecializeDto> GetSpezializations(List<College> colleges)
        {
            var spec = colleges.SelectMany(item => item.Students.Select(itemInv => itemInv.Specialization)
                   .GroupBy(itemTuple => itemTuple)
                   .Select(g => new SpecializeDto { Specialization = g.Key, Count = g.Count(), Title = item.Title })).ToList();

            return spec;
        }

        /// <summary>
        /// Return the College with max students count.
        /// </summary>
        /// <param name="colleges">List of colleges to find college with max students count.</param>
        /// <returns>College, representing the college with max students count.</returns>
        public static College GetCollegeByMaxStudentsCount(List<College> colleges)
        {
            return colleges.Aggregate((maxCount, curCount) => maxCount.Students.Count > curCount.Students.Count ? maxCount : curCount);
        }

        /// <summary>
        /// Returns the sorted by salary list of Employee.
        /// </summary>
        /// <param name="college">College college to be used for sort employees by salary.</param>
        /// <returns>List of Employee, representing the sorted employees by salary.</returns>
        public static List<Employee> GetEmployeesOrderBySalary(College college)
        {
            return college.Employees.OrderBy(i => i.Salary).ToList();
        }
    }
}
