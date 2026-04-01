using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            //ArgumentException invalidArgumentException = new ArgumentException("ArgumentException: The 'GraphData' method received data outside the expected range.");
            //throw invalidArgumentException;

            //throw new FormatException("FormatException: Calculations in process XYZ have been cancelled due to invalid data format.");
            string[][] userEnteredValues = new string[][]
{
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
};

            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    BusinessProcess1(userEntries);
                }
                catch (Exception ex)
                {
                    if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        // completes required calculations based on userValue
                        // ...
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                }
            }
        }
    }
}
