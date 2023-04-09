// <copyright file="FileReader.cs" company="MyCompany">
// Copyright 2023 MyCompany. All rights reserved.
// </copyright>

namespace FinalTask.Data
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;
    using Serilog;

    /// <summary>
    /// Class FileReader for get data from file.
    /// </summary>
    public class FileReader
    {
        private readonly string fileCollegesPath = ConfigurationManager.AppSettings["fileCollegesPath"];

        /// <summary>
        /// Deserialize data from file.
        /// </summary>
        /// <returns>List of College, representing deserializing list of College data from file.</returns>
        public List<College> ReadFile()
        {
            try
            {
                if (File.Exists(this.fileCollegesPath))
                {
                    using (StreamReader streamReader = new StreamReader(this.fileCollegesPath, Encoding.UTF8))
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
                    throw new Exception($"File {this.fileCollegesPath} doesn't exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Log.Error($"Exception: {ex.Message} \nPlace of occurrence: {ex.TargetSite}");
            }

            return null;
        }
    }
}
