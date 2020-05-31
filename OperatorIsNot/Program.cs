using System;

namespace OperatorIsNot
{
    class Program
    {
        static void Main()
        {
            var values = new object[] { "Test 1", 2, 3.0, null, "Test 5", null, DateTime.Now };

            foreach (object value in values)
            {
                if (value is not null)
                {
                    if (value is not string)
                        Console.WriteLine($"Type: {value.GetType().FullName} - Value: {value}");
                    else
                        Console.WriteLine($"Found a string: {value}");
                }
                else
                    Console.WriteLine("Found a value null...");
            }
        }
    }
}
