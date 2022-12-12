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

            footballPasal fp = new footballPasal(10,15,20);
            
            Console.WriteLine(fp.GetIncome());
            Console.WriteLine(fp.GetProfit());
            Console.ReadLine();

        }
    }
}
