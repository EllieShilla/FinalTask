// <copyright file="MainProgram.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask.Data
{
    using System;
    using System.Collections.Generic;
    using FinalTask.Log;
    using Serilog;

    /// <summary>
    /// Class MainProgram which was starting methods of classes FileReader and FileRecorder.
    /// </summary>
    public class MainProgram
    {
        private FileReader fileReader;
        private FileRecorder fileRecorder;
        private Logger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainProgram"/> class.
        /// </summary>
        public MainProgram()
        {
            this.fileReader = new FileReader();
            this.fileRecorder = new FileRecorder();
            this.logger = new Logger();
        }

        /// <summary>
        /// Start working methods for deserializing, procesing and serializing college data.
        /// </summary>
        public void WorkProgram()
        {
            try
            {
                if (this.fileReader.ReadFile() != null)
                {
                    List<College> colleges = this.fileReader.ReadFile();

                    if (this.fileRecorder.WriteSpecializationsToFile(DataProcessor.GetSpezializations(colleges)))
                    {
                        Console.WriteLine(@"Spezializations are written to a 'file1.txt'.");
                    }

                    if (this.fileRecorder.WriteToFileOrderBySalaryEmployees(DataProcessor.GetEmployeesOrderBySalary(DataProcessor.GetCollegeByMaxStudentsCount(colleges))))
                    {
                        Console.WriteLine(@"Sorted college employees saved to a 'file2.txt'.");
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Exception: {ex.Message} \nPlace of occurrence: {ex.TargetSite}");
            }
        }
    }
}
