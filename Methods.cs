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

        public double FindMinMax(params double[]number){
            var number = 0;
            foreach(var i in number){
                double smallest = Min();
                double largst = Max();

            }
        }

    }
}
