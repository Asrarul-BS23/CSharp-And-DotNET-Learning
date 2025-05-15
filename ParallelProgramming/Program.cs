using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgrammingDemo;

class Program
{
    static void Main()
    {
        List<int> integerList = Enumerable.Range(1, 10).ToList();

        Console.WriteLine("Parallel For Loop Started");
        Parallel.For(1, 11, number => {
            Console.WriteLine(number);
        });
        Console.WriteLine("Parallel For Loop Ended");

        Console.WriteLine("Parallel Foreach Loop Started");
        Parallel.ForEach(integerList, i =>
        {
            long total = DoSomeIndependentTimeconsumingTask();
            Console.WriteLine("{0} - {1}", i, total);
        });
        Console.WriteLine("Parallel Foreach Loop Ended");

        //Calling Three methods Parallely
        Console.WriteLine("Parallel Invoke Started");
        Parallel.Invoke(
             Method1, Method2, Method3
        );
        Console.WriteLine("Parallel Invoke Ended");
        Console.ReadLine();
    }

    static long DoSomeIndependentTimeconsumingTask()
    {
        //Do Some Time Consuming Task here
        long total = 0;
        for (int i = 1; i < 100000000; i++)
        {
            total += i;
        }
        return total;
    }

    static void Method1()
    {
        Thread.Sleep(250);
        Console.WriteLine($"Method 1 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
    }
    static void Method2()
    {
        Thread.Sleep(220);
        Console.WriteLine($"Method 2 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
    }
    static void Method3()
    {
        Thread.Sleep(200);
        Console.WriteLine($"Method 3 Completed by Thread={Thread.CurrentThread.ManagedThreadId}");
    }
}