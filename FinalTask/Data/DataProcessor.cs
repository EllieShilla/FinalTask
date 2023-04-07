using FinalTask.Dto;
using System.Collections.Generic;
using System.Linq;

namespace FinalTask.Data
{
    public class DataProcessor
    {
        public static List<SpezializeDto> GetSpezializations(List<College> colleges)
        {
            var spec = colleges.SelectMany(item => item.Students.Select(itemInv => itemInv.Specialization)
                   .GroupBy(itemTuple => itemTuple)
                   .Select(g => new SpezializeDto { Specialization = g.Key, Count = g.Count(), Title = item.Title })).ToList();

            return spec;
        }

        public static College GetCollegeByMaxStudentsCount(List<College> colleges)
        {
            return colleges.Aggregate((maxCount, curCount) => maxCount.Students.Count > curCount.Students.Count ? maxCount : curCount);
        }

        public static List<Employee> GetEmployeesOrderBySalary(College college)
        {
            return college.Employees.OrderBy(i => i.Salary).ToList();
        }
    }
}
