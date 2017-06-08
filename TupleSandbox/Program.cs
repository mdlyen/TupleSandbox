using System;

namespace TupleSandbox
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Tuple Test Stuff.
            var dateTemp = new MdlDateTime(DateTime.Now);

            (int Hour, int Minutes, int Seconds) = dateTemp;

            Console.WriteLine($"Current time: {Hour}:{Minutes}:{Seconds}");
        }
    }
}