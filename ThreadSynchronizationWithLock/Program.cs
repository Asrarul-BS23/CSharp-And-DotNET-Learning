/*
<============ Before C# 13 ==============>
Without Threading.Lock()
 */

using System.Threading;

namespace ThreadSynchronizationWithAndWithoutLock;

//public class Program
//{
//    static int counter = 0;
//    static readonly object lockobj = new object();

//    static void Main(string[] args)
//    {
//        //creating multiple threads
//        Thread thread1 = new Thread(IncrementCounter);
//        Thread thread2 = new Thread(IncrementCounter);

//        //start threads
//        thread1.Start();
//        thread2.Start();

//        //Wait for threads to complete
//        thread1.Join();
//        thread2.Join();

//        //Final Counter value after execution of both threads
//        Console.WriteLine($"Final Counter Value: {counter}");
//    }

//    static void IncrementCounter()
//    {
//        // Locking the critical section
//        lock (lockobj)
//        {
//            int temp = counter;
//            temp++;
//            Thread.Sleep(100); //simulating some work
//            counter = temp;
//            Console.WriteLine($"Counter: {counter}");
//        }
//    }
//}


/*
<========== In C# 13 ==========>
With Threading.Lock()
 */

public class Program
{
    static int counter = 0;
    static readonly Lock lockobj = new Lock();

    static void Main(string[] args)
    {
        //creating multiple threads
        Thread thread1 = new Thread(IncrementCounter);
        Thread thread2 = new Thread(IncrementCounter);

        //start threads
        thread1.Start();
        thread2.Start();

        //Wait for threads to complete
        thread1.Join();
        thread2.Join();

        //Final Counter value after execution of both threads
        Console.WriteLine($"Final Counter Value: {counter}");
    }

    static void IncrementCounter()
    {
        // Locking the critical section
        using (lockobj.EnterScope()) //EnterScope acquires the lock
        {
            int temp = counter;
            temp++;
            Thread.Sleep(100); //simulating some work
            counter = temp;
            Console.WriteLine($"Counter: {counter}");
        }
    }
}