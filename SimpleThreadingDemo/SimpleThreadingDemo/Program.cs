using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Counting);
            Thread thread1 = new Thread(Counting);
            Thread thread2 = new Thread(Counting);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.ReadKey();
        }

        public static void Counting()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Count: { i + 1}");
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}\n");
                Thread.Sleep(10);
            }
        }
    }
}
