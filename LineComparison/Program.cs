using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME");
            LineComparison lc = new LineComparison();
            lc.length_line();
            lc.Comparelines();
            Console.ReadLine();
        }
    }
}