using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Transportation
    {
        public void WayOfTravel(string Enter)
        {
            Console.WriteLine($"\nWill Travel Through: {Enter}");
        }
        public void By(string by)
        {
            Console.WriteLine($"Travel By: {by}");
        }
    }
}
