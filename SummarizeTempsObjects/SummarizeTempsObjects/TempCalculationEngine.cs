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
            // add logic to calculate the average
        }

        public int TempsAboveThreshold(int threshold)
        {
            // add logic to calculate temps above the threshold
        }

        public int TempsBelowThreshold(int threshold)
        {
            // add logic to calculate and return temps below the threshold
        }

        public int TempsAtThreshold(int threshold)
        {
            // add logic to calculate and return temps at the threshold
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
        }
    }
}
