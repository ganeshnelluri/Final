using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections;

namespace HelloWorld
{
    class Program
    {

        public static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a :{a},b:{b}");
            int sum = 0;
            sum = a + b;

            Console.WriteLine($"sum of given numbers:{sum}");
            Console.WriteLine("enter a string");
            int adv = int.Parse(Console.ReadLine());
            Console.WriteLine($"{adv}");

            Program obj1 = new Program();
            obj1.PRI();
            Program.stat();
            obj1.inte();
            Practice obj2 = new Practice();
            obj2.inte();
            obj1.genericspr();
            //ref and fout
            int x = 5;
            int y;
            obj1.ProcessValues(ref x, out y);

            Console.WriteLine(x); // Output: 15
            Console.WriteLine(y); // Output: 30
            int xx = 3;
            int yy;
            obj1.ProcessValues(ref xx, out yy);

            Console.WriteLine(xx); // Output: 15
            Console.WriteLine(yy);





        }
        private void PRI()
        {
            int a = 10;
            Console.WriteLine("Value from Private method:" + a);
            //accessible within the class not even in the derived classes
        }
        static void stat()
        {

            int b = 10;
            Console.WriteLine("value fromm static method:" + b);
            //accessible by using class name directly, we can create instance for static methods
        }
        internal void inte()
        {
            int a = 10;
            Console.WriteLine("Value from Internal method:" + a);
            //accessible everywhere in the assemly
        }
        public void genericspr()
        {
            List<int> list = new List<int>();
            list.Add(10);

            list.Add(110); list.Add(130);
            list.Add(102);
            list.Add(103);
            list.Add(105);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Stack<int> values = new Stack<int>();
            values.Push(10);
            values.Push(1011);
            values.Push(1022);
            values.Push(1033);

            Console.WriteLine("values from stack");
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("deleted stack");
            values.Pop();
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(210);
            queue.Enqueue(310);
            queue.Enqueue(410);
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("queue deleted");
            queue.Dequeue();
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
        }
       
            // ref and out
           
        public void reff(ref int a)
        {
            int x = 5;
        
        }
           public void ProcessValues(ref int a, out int b)
        {
                 // Modify existing value
            b = a * 2;    // Must assign out parameter
        }

        public void ownrefout(ref int a, out int b)
        {
            a = 5;
            b = a * 2;
            b = a;
            //ref modifies the orginnal value, where out is used to return multiple values

        }
        IStudentservice Studentservice = new Practice();

        Studentservice.Add(3,4);



    }
}

