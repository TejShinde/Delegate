using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate int MyDelegate(int x, int y); // Single-cast delegate

    public class SingleCastDelegate
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

    class SingleCastExample
    {
        static void Main(string[] args)
        {
            SingleCastDelegate c = new SingleCastDelegate();

            // Single-cast delegate object
            MyDelegate singleDelegate = new MyDelegate(c.Add);

            // Invoking single delegate
            int result = singleDelegate.Invoke(10, 20);
            Console.WriteLine("Single-cast delegate result (Add): " + result);
        }
    }
}
