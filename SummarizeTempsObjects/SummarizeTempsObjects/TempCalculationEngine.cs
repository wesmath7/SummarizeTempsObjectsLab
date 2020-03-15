using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }
        
        public int AverageTemperature()
        {
            int tempTotal = 0;
            // add logic to calculate the average
            foreach (int dayTemp in _temperatures)
            {
               tempTotal = tempTotal + dayTemp;
            }
            int average = tempTotal / _temperatures.Count;
            return average; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
            int count = 0;
            foreach(int e in _temperatures)
            {
                if(e>threshold)
                {
                    count++;
                }
            }
               return count; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold

            int count = 0;
            foreach (int e in _temperatures)
            {
                if (e < threshold)
                {
                    count++;
                }
            }
            return count; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
            int count = 0;
            foreach (int e in _temperatures)
            {
                if (e == threshold)
                {
                    count++;
                }
            }
            return count;
            // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
