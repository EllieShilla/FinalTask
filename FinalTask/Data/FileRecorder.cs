using FinalTask.Dto;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace FinalTask.Data
{
    public class FileRecorder
    {
        readonly string file1Path = ConfigurationManager.AppSettings["file1Path"];
        readonly string file2Path = ConfigurationManager.AppSettings["file2Path"];

        public bool WriteSpecializationsToFile(List<SpezializeDto> spezializes)
        {
            using (StreamWriter streamWriter = new StreamWriter(file1Path, false, Encoding.UTF8))
            {
                string collegeName = spezializes[0].Title;
                streamWriter.WriteLine(collegeName);

                foreach (var item in spezializes)
                {
                    if (!collegeName.Equals(item.Title))
                    {
                        collegeName = item.Title;
                        streamWriter.WriteLine("\n");
                        streamWriter.WriteLine(collegeName);

                    }
                    streamWriter.WriteLine(item.Specialization + " - " + item.Count);
                }
                return true;
            }
        }

        public bool WriteToFileOrderBySalaryEmployees(List<Employee> employees)
        {
            using (StreamWriter streamWriter = new StreamWriter(file2Path, false, Encoding.UTF8))
            {
                foreach (var employee in employees)
                {
                    streamWriter.WriteLine(employee.FirstName + " " + employee.ThirdName + " " + employee.SecondName + ": " + employee.Salary);
                }
                return true;
            }
        }
    }
}
