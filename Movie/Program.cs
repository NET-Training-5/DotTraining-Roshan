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
            Movie avengers = new Movie("The avengaer", "johan", "dofas");
            Movie Shark = new Movie("The Sshark", "haery", "RR");
            
            Console.WriteLine(avengers.Rating);

            Console.ReadLine();
        }
    }
}
