using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                   {
            Hostel SUPA = new Hostel("SUPA", 40, "Girls","Sankhamul");
            Hostel SUPA_Girs = new Hostel("SUPA Girls", 32,"Girls", "Sankhamul");
          
            Console.WriteLine(SUPA_Girs.studentsCapacity);
            Console.WriteLine(SUPA.Type);
            Console.ReadLine();
        }
        }
    }
}
