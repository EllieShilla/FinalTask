using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace FinalTask.Data
{
    public class FileReader
    {
        readonly string collegesFilePath = ConfigurationManager.AppSettings["folderCollegesPath"];

        public List<College> ReadFile()
        {
            try
            {
                if (File.Exists(collegesFilePath))
                {
                    using (StreamReader streamReader = new StreamReader(collegesFilePath, Encoding.UTF8))
                    {
                        string json = streamReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(json))
                            return JsonConvert.DeserializeObject<CollegeList>(json).colleges;
                        else
                            throw new Exception("File is empty.");
                    }
                }
                else
                    throw new Exception($"File {collegesFilePath} doesn't exist.");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
