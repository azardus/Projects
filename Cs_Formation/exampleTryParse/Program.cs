﻿using System;

namespace exampleTryParse
{
    class Program
    {
        /// <summary>
        /// Gets an integer from the user input.
        /// </summary>
        /// <returns>User input text as an integer value.</returns>
        public static void Main()
        {
            String[] values = { null, "160519", "9432.0", "16,667", "   -322   ", "+4302", "(100);", "01FA" };

            foreach (var value in values)
            {
                int number;

                bool success = Int32.TryParse(value, out number);
                if (success)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", value, number);
                }
                else
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       value ?? "<null>");
                }
            }
        }
    }
}