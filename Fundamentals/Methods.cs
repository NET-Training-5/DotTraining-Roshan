using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals1
{
    internal class Methods
    {
        //simplest possible :  returns nothung, takes no arguments.   

       public void PrintMessage()
        {
            Console.WriteLine("Nepal is beautiful");
        }

        //returns nothing takes some arguments 

        public void Print(string message)
        {
            Console.WriteLine(message);
        } 


        //returns something  takes no arguments

        public string GetMessage()
        {
            return "kathmandu";
        }

        //returns something , takes arguments

        public double Add(double a, double b) => a + b;


        // Expression bodied members

       public double Numbers(double a, double b, double c)
        {
            double v = (a + b + c) / 3; 
            double average = v;
            return average;
        }


        public double FindAverage(params int[]items){
            var sum = 0;
            foreach(var i in items)
            {
                sum = sum+1;

            }
            var average = (double)sum/items.Length;
            return average;
        }

        public void FindMinMax()
        {
            int i = 0;
            double[] minmax = { 2, 4, 9, 4, 3, 543, 8, 324, 12, 1, 321, 323 };
            Console.WriteLine("minimum number is"+ minmax.Min());
            Console.WriteLine("maximum number is "+ minmax.Max());
            
            


        }




          public void DrawPattern()
        {
            
            for(int row = 1; row <=6; ++row)
            {
                for(int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
        }


        public void DrawPattern2()
        {
            for(int row = 1; row <=6;  ++row)
            {
                for(int column = 1; column <= row; ++column)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
        }

    }
}
