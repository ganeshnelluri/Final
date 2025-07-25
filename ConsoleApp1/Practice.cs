using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Practice:IStudentservice
    {
        private void PRI()
        {
            int a = 10;
            Console.WriteLine("Value from prActic Private method:" + a);
        }
        static void statpr()
        {
            int b = 10;
            Console.WriteLine("value fromm prActic static method:" + b);
        }
        internal void inte()
        {
            int a = 10;
            Console.WriteLine("Value from prActic Internal method:" + a);
        }
        protected void printe()
        {
            int a = 10;
            Console.WriteLine("Value from prActic protected Internal method:" + a);
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int SUB(int a, int b)
        {
            return a - b;
        }

        public int MUL(int a, int b)
        {
            return a * b;
        }



    }
}

