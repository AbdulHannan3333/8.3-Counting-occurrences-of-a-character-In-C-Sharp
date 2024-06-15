using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Counting_occurrences_of_a_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Programming";
            char target = 'g';
            int count = 0;
            foreach (var item in input)
            {
                if (item == target) 
                {
                count++;
                }
            }
            Console.WriteLine($"Occurrance of '{target}' in '{input}': '{count}'");
        }
    }
}
