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

                    // TODO - print out the results

                    /* Print the following results to the console:
                     * Number of temperatures in the file
                     * Number of temperatures above the provided threshold 
                     * Number of temperatures below the provided threshold 
                     * Number of temperatures at the provided threshold 
                     * The average of the temperatures
                     */

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
