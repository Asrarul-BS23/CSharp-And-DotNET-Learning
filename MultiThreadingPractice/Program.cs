using System.Threading;
using System;
namespace MultiThreadingPractice;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Here is the printer.");

        Console.ReadKey();

        Thread t = Thread.CurrentThread;
        //By Default, the Thread does not have any name
        //if you want then you can provide the name explicitly
        t.Name = "Main Thread";
        Console.WriteLine("Current Executing Thread Name : " + t.Name);
        Console.WriteLine("Current Executing Thread Name : " + Thread.CurrentThread.Name);

        Console.Read();
    }
}


//class Program
//{
//    static void Main(string[] args)
//    {
//        Thread t = Thread.CurrentThread;
//        //By Default, the Thread does not have any name
//        //if you want then you can provide the name explicitly
//        t.Name = "Main Thread";
//        Console.WriteLine("Current Executing Thread Name : " + t.Name);
//        Console.WriteLine("Current Executing Thread Name : " + Thread.CurrentThread.Name);

//        Console.Read();
//    }
//}
