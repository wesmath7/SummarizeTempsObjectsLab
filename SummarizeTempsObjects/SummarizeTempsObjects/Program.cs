using System;

namespace SummarizeTempsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // temperature data is in temps.txt

            // prompt for the name of the file
            Console.WriteLine("Enter the name of the data file:");
            string filePath = Console.ReadLine();

            FileAccessor accessor = new FileAccessor(filePath);

            accessor.LoadTemperatureData();

            if (accessor.Temperatures.Count > 0)
            {
                TempCalculationEngine engine = new TempCalculationEngine(accessor.Temperatures);

                bool repeat = true;

                while (repeat)
                {
                    int threshold = GetInput("Enter the threshold temperature:");

                    // print the results
                    WriteResult("Total temperatures", engine.NumberOfTemperatures());
                    WriteResult("Temperatures above the threshold", engine.TempsAboveThreshold(threshold));
                    WriteResult("Temperatures below the threshold", engine.TempsBelowThreshold(threshold));
                    WriteResult("Temperatures at the threshold", engine.TempsAtThreshold(threshold));
                    WriteResult("Average temperature", engine.AverageTemperature());

                    // check to see if use wants to test another threshold
                    int quit = GetInput("Enter 0 to quit or 1 to continue");

                    if (quit == 0)
                    {
                        repeat = false;
                    }
                }

            }
        }

        static int GetInput(string prompt)
        {
            Console.WriteLine(); // write a blank line for readability 
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine());
        }

        static void WriteResult(string prompt, int result)
        {
            Console.WriteLine(prompt + " " + result);
        }
    }
}
