namespace FinalTask.Data
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// Class FileReader for get data from file.
    /// </summary>
    public class FileReader
    {
        private readonly string collegesFilePath = ConfigurationManager.AppSettings["folderCollegesPath"];

        /// <summary>
        /// Deserialize data from file.
        /// </summary>
        /// <returns>List of College, representing deserializing list of College data from file.</returns>
        public List<College> ReadFile()
        {
            try
            {
                if (File.Exists(this.collegesFilePath))
                {
                    using (StreamReader streamReader = new StreamReader(this.collegesFilePath, Encoding.UTF8))
                    {
                        string json = streamReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(json))
                        {
                            return JsonConvert.DeserializeObject<CollegeList>(json).Colleges;
                        }
                        else
                        {
                            throw new Exception("File is empty.");
                        }
                    }
                }
                else
                {
                    throw new Exception($"File {this.collegesFilePath} doesn't exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
