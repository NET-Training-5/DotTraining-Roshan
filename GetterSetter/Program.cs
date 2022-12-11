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


            Fifa worldcup2018 = new Fifa();
            {
            worldcup2018.host = "Russia";
            worldcup2018.year = new DateTime(2018, 2, 3);
            worldcup2018.winner = "France";
            worldcup2018.teams = new string[]{"France","Germany","Morocco","crotia"};
            Fifa worldcup2020 = new Fifa("Quatar");

    	    Fifa worldcup2022 =  new Fifa("Qatar", new DateTime(2002, 2,2), "Nepal",new string[]
            {"France","Germany","Morocco","crotia"});

            Fifa.NoOfGroups = 9;


        }
        }
    }
    }
}

