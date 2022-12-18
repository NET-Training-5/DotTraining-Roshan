using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Practice
{
    internal class Assignment6
    {
        string[] countries = { "Nepal", "India", "China", "Srilanka", "Afganstan", "Russia", "Bhutan", "Thailand " };

        public void starting()
        {
           var startingWithN = from x in countries where x.StartsWith("N")
                               select x;
            DisplayValues(starting, "starting with N counteries");



        }

        public void letterLessThan4()
        {
           var less = from x in countries where x.Length<4
                      select x;
            DisplayValues(less, "less than 4 character counteries");
        }
        

        public void upperCasse()
        {
            var upper = countries.Select(x => x.ToUpper());
            DisplayValues(upper, "upper case counteries");
        }



        void DisplayValues<T>(IEnumerable<T> elements, string label)
        {
            Console.Write($"\n{label}");
            foreach (var x in elements)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

        }

    }
}
