using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask.Data
{
    public class MainProgram
    {
        FileReader fileReader;
        FileRecorder fileRecorder;
        public MainProgram()
        {
            fileReader = new FileReader();
            fileRecorder = new FileRecorder();
        }

        public void WorkProgram()
        {
            if (fileReader.ReadFile() != null)
            {
                List<College> colleges = fileReader.ReadFile();

                if (fileRecorder.WriteSpecializationsToFile(DataProcessor.GetSpezializations(colleges)))
                    Console.WriteLine(@"Spezializations are written to a 'file1.txt'.");

                if (fileRecorder.WriteToFileOrderBySalaryEmployees(DataProcessor.GetEmployeesOrderBySalary(DataProcessor.GetCollegeByMaxStudentsCount(colleges))))
                    Console.WriteLine(@"Sorted college employees saved to a 'file2.txt'.");
            }
        }
    }
}
