using FinalTask.Data;
using System;
using System.Collections.Generic;

namespace FinalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            FileRecorder fileRecorder = new FileRecorder();

            if (fileReader.ReadFile() != null)
            {
                List<College> colleges = fileReader.ReadFile();

                if (fileRecorder.WriteSpecializationsToFile(DataProcessor.GetSpezializations(colleges)))
                    Console.WriteLine(@"Spezializations are written to a 'file1.txt'.");

                if (fileRecorder.WriteToFileOrderBySalaryEmployees(DataProcessor.GetEmployeesOrderBySalary(DataProcessor.GetCollegeByMaxStudentsCount(colleges))))
                    Console.WriteLine(@"Sorted college employees saved to a 'file2.txt'.");
            }

            Console.ReadLine();
        }
    }
}
