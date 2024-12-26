using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a code num:");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                ArrayList studentName = new ArrayList();

                studentName.Add(2);
                studentName.Add(3);
                studentName.Add(4);
                studentName.Add(5);
                Console.WriteLine("after adding:" + string.Join(",", studentName.ToArray()));

                studentName.RemoveAt(2);
                Console.WriteLine("after romove:" + string.Join(",", studentName.ToArray()));

                studentName.RemoveRange(0, 2);
                Console.WriteLine("sfter romoverange:" + string.Join(",", studentName.ToArray()));

                studentName.Clear();
                Console.WriteLine("count:" + studentName.Count);
                Console.ReadLine();
            }

            if (num == 2)
            {
                List<string> studentName = new List<string>();

                studentName.Add("abc");
                studentName.Add("def");
                studentName.Add("ghi");
                studentName.Add("xyz");
                Console.WriteLine("after adding:" + string.Join(",", studentName.ToArray()));

                studentName.RemoveAt(2);
                Console.WriteLine("after romove:" + string.Join(",", studentName.ToArray()));

                studentName.RemoveRange(0, 2);
                Console.WriteLine("sfter romoverange:" + string.Join(",", studentName.ToArray()));

                studentName.Clear();
                Console.WriteLine("count:" + studentName.Count);
                Console.ReadLine();
            }

            if (num == 3)
            {
                Stack<int> stack = new Stack<int>();

                stack.Push(10);
                stack.Push(20);
                stack.Push(30);
                stack.Push(40);
                stack.Push(50);
                Console.WriteLine("after adding:" + string.Join(",", stack));


                Console.WriteLine("after romove:" + stack.Pop());


                Console.WriteLine("after romoverange:" + stack.Peek());


                Console.WriteLine("after contains:" + stack.Contains(20));

                stack.Clear();
                Console.WriteLine("count:" + stack.Count);
                Console.ReadLine();
            }

            if (num == 4)
            {

                Queue<int> q = new Queue<int>();

                q.Enqueue(10);
                q.Enqueue(20);
                q.Enqueue(30);
                q.Enqueue(40);
                Console.WriteLine("after adding:" + string.Join(",", q));


                Console.WriteLine("after romove:" + q.Dequeue());


                Console.WriteLine("sfter romoverange:" + q.Peek());


                Console.WriteLine("after contains:" + q.Contains(20));

                q.Clear();
                Console.WriteLine("count:" + q.Count);
                Console.ReadLine();
            }

            if (num == 5)
            {
                Dictionary<int, string> d = new Dictionary<int, string>();

                d.Add(1, "abc");
                d.Add(2, "efg");
                d.Add(3, "ggj");
                d.Add(4, "fff");
                Console.WriteLine("after adding:" + string.Join(",", d));


                Console.WriteLine("after romove:" + d.Remove(1));


                Console.WriteLine("value of 1:" + d[2]);


                Console.WriteLine("after containskey:" + d.ContainsKey(2));
                Console.WriteLine("after containsvalue:" + d.ContainsValue("ggj"));

                d.Clear();
                Console.WriteLine("count:" + d.Count);
                Console.ReadLine();
            }
            if (num == 6)
            {
                Hashtable h = new Hashtable();

                h.Add(1, "abc");
                h.Add(2, "efg");
                h.Add(3, "ggj");
                h.Add(4, "fff");
                Console.WriteLine("after adding:" + string.Join(", ", h.Keys.Cast<int>().Select(k => k + "=" + h[k])));

                h.Remove(3);
                Console.WriteLine("after romove:" + string.Join(", ", h.Keys.Cast<int>().Select(k => k + "=" + h[k])));


                Console.WriteLine("ContainsKey:" + h.ContainsKey(1));
                Console.WriteLine("ContainsValue:" + h.ContainsValue("efg"));

                h.Clear();
                Console.WriteLine("count:" + h.Count);
                Console.ReadLine();

            }
        }
    }
}
