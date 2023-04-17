using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ThreadPool_Øvelse_1_Og_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates object of datatype stopwatch
            Stopwatch mywatch = new Stopwatch();

            //Starts test with threadpooling, start stopwatch and stops it when the process is done
            Console.WriteLine("Thread Pool Execution");
            mywatch.Start();
            ProcessWithThreadPoolMethod();
            mywatch.Stop();

            //Show time used with threadpooling
            Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
            mywatch.Reset();

            //Starts test with Threding, start stopwatch and stops it when process is done
            Console.WriteLine("Thread Execution");
            mywatch.Start();
            ProcessWithThreadMethod();
            mywatch.Stop();

            //Show time used with Threding
            Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());

            Console.Read();
        }
        //Process
        static void Process(object callback)
        {
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                }
            }
        }
        //Processing with threding
        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
            }
        }
        //Processing with Thredpooling
        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
            }
        }
    }
}
