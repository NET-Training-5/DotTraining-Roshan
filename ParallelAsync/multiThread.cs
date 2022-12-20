using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelAsync
{
    internal class multiThread
    {

        public void writeParallelCode()
        {
            for(int i = 0; i < 10; i++)
            {
                DoTask(i);
            }

            Console.WriteLine("parallel :");

            Parallel.For(1, 11, i => DoTask(i));


                void DoTask(int counter)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"Doone with task {counter}");
            }
        }
    }
}
