﻿using System;
using System.Threading;

namespace ThreadingDemo;

/*
 <========== Without Using Multi-Threading =========>
The whole process is using single thread and excuting
the all code paths in this thread.
 */
//class Program
//{
//    static void Main(string[] args)
//    {
//        Method1();
//        Method2();
//        Method3();
//        Console.Read();
//    }

//    static void Method1()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Method1 :" + i);
//        }
//    }

//    static void Method2()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Method2 :" + i);
//            if (i == 3)
//            {
//                Console.WriteLine("Performing the Database Operation Started");
//                //Sleep for 10 seconds
//                Thread.Sleep(10000);
//                Console.WriteLine("Performing the Database Operation Completed");
//            }
//        }
//    }

//    static void Method3()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Method3 :" + i);
//        }
//    }
//}

/*
 <========== Using Multi-Threading =========>
The whole process is using multiple thread and excuting
the different code paths (methods) in different thread.
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main Thread Started");

        //Creating Threads
        Thread t1 = new Thread(Method1)
        {
            Name = "Thread1"
        };
        Thread t2 = new Thread(Method2)
        {
            Name = "Thread2"
        };
        Thread t3 = new Thread(Method3)
        {
            Name = "Thread3"
        };

        //Executing the methods
        t1.Start();
        t2.Start();
        t3.Start();
        Console.WriteLine("Main Thread Ended");
        Console.Read();
    }
    static void Method1()
    {
        Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
        Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
    }

    static void Method2()
    {
        Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method2 :" + i);
            if (i == 3)
            {
                Console.WriteLine("Performing the Database Operation Started");
                //Sleep for 10 seconds
                Thread.Sleep(10000);
                Console.WriteLine("Performing the Database Operation Completed");
            }
        }
        Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
    }
    static void Method3()
    {
        Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Method3 :" + i);
        }
        Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
    }
}
