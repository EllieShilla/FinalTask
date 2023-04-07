// <copyright file="FileRecorder.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask.Data
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Text;
    using FinalTask.Dto;

    /// <summary>
    /// Class FileRecorder for write data to file.
    /// </summary>
    public class FileRecorder
    {
        private readonly string file1Path = ConfigurationManager.AppSettings["file1Path"];
        private readonly string file2Path = ConfigurationManager.AppSettings["file2Path"];

        /// <summary>
        /// Write list of SpezializeDto into file.
        /// </summary>
        /// <param name="specializes">The list of SpezializeDto ordered by specialization for saving into file.</param>
        /// <returns>A bool, representing that method worked well.</returns>
        public bool WriteSpecializationsToFile(List<SpecializeDto> specializes)
        {
            using (StreamWriter streamWriter = new StreamWriter(path: this.file1Path, false, Encoding.UTF8))
            {
                string collegeName = specializes[0].Title;
                streamWriter.WriteLine(collegeName);

                foreach (var item in specializes)
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

        /// <summary>
        /// Write sorted by salary list of Employee into file.
        /// </summary>
        /// <param name="employees">The list of Employee ordered by salary for saving into file.</param>
        /// <returns>A bool, representing that method worked well.</returns>
        public bool WriteToFileOrderBySalaryEmployees(List<Employee> employees)
        {
            using (StreamWriter streamWriter = new StreamWriter(this.file2Path, false, Encoding.UTF8))
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
