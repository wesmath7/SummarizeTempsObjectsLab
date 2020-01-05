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
            // add logic here to load the data from the file
        }
    }
}
