using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
        public delegate int MyDelegate(int x, int y); // Multi-cast delegate

        public class MultipleCastDelegate
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }

            public int Multiply(int a, int b)
            {
                return a * b;
            }
        }

        class MultiCastExample
        {
            static void Main(string[] args)
            {
            MultipleCastDelegate c = new MultipleCastDelegate();

                // Multi-cast delegate object
                MyDelegate multiDelegate = new MyDelegate(c.Multiply);
                multiDelegate += new MyDelegate(c.Sub);
                multiDelegate += new MyDelegate(c.Add);

                // Removing a method from the invocation list
                multiDelegate -= new MyDelegate(c.Sub);

                // Invoking the delegate and displaying results
                Delegate[] invocationList = multiDelegate.GetInvocationList();
                foreach (Delegate method in invocationList)
                {
                    Console.WriteLine($"Invoking {method.Method.Name}...");
                    Console.WriteLine("Result: " + method.DynamicInvoke(45, 33));
                }
            }
        }
    }
