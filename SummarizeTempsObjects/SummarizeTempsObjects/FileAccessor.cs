using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SummarizeTempsObjects
{
    public class FileAccessor
    {
        string _filePath = "";

        public List<int> Temperatures = new List<int>();
        public FileAccessor(string filePath)
        {
            _filePath = filePath;

        }

        public void LoadTemperatureData()
        {
            if (File.Exists(_filePath))
            {
                using (StreamReader sr = File.OpenText(_filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // convert the string temp to an int
                        int temp = int.Parse(line);

                        // add to the ArrayList
                        Temperatures.Add(temp);
                    }
                }
            }
        }
    }
}
