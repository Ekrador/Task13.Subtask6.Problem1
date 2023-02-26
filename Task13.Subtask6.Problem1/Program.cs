using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task13.Subtask6.Problem1
{
    internal class Program
    {
        static Stopwatch stopWatch;
        static void Main(string[] args)
        {
            string[] path = { @"C:\Users", Environment.UserName, "Desktop", "Text.txt" };
            string fullPath = Path.Combine(path);
            string text = File.ReadAllText(fullPath);
            
            List<char> list = new List<char>();
            LinkedList<char> linkedList = new LinkedList<char>();

            Console.Write("Добавление в конец List<T>: ");
            ResetStopWatch();
            foreach (char letter in text)
            {
                list.Add(letter);
            }
            var result  = stopWatch.Elapsed.TotalMilliseconds;
            Console.WriteLine(result + " миллисекунд");

            Thread.Sleep(2000);

            Console.Write("Вставка между позициями List<T>: ");
            list.Clear();
            ResetStopWatch();
            list.Add(' ');
            foreach (char letter in text)
            {
                list.Insert(1, letter);
            }
            result = stopWatch.Elapsed.TotalMilliseconds;
            Console.WriteLine(result + " миллисекунд");

            Thread.Sleep(2000);

            Console.Write("Добавление в конец LinkedList<T>: ");
            ResetStopWatch();
            foreach (char letter in text)
            {          
                linkedList.AddLast(letter);
            }
            result = stopWatch.Elapsed.TotalMilliseconds;
            Console.WriteLine(result + " миллисекунд");

            Thread.Sleep(2000);

            Console.Write("Вставка между позициями LinkedList<T>: ");
            linkedList.Clear();
            ResetStopWatch();
            linkedList.AddLast(' ');
            foreach (char letter in text)
            {

                linkedList.AddBefore(linkedList.Last, letter);
            }
            result = stopWatch.Elapsed.TotalMilliseconds;
            Console.WriteLine(result + " миллисекунд");

            Console.ReadLine();
        }

        static void ResetStopWatch()
        {
            stopWatch = Stopwatch.StartNew();
        }
    }
}
