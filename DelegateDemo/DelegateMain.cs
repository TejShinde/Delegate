using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateDemo.Program;

namespace DelegateDemo
{
    internal class DelegateMain
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            // delegate object
            MyDelegate obj = new MyDelegate(c.Multiply);// added method ref
            int result = obj.Invoke(20, 30); //600 in absence of invokelist() but others result for sub ,add not printed,u have create var like result for each
            Console.WriteLine(result);
            obj += new MyDelegate(c.Sub); // += add in to the invocation list
            obj += new MyDelegate(c.Add);

            obj -= new MyDelegate(c.Sub); // -= will remove method from invocation list

            // Delegate will create the invocationList 
            // invocationList hold methods refer in the same sequence that we have added
            // basic need of multicast delegate is --> to invoke methods in a sequence.

            Delegate[] list = obj.GetInvocationList(); //for multicast
            foreach (Delegate item in list)
            {
                Console.WriteLine(item.Method);
                Console.WriteLine(item.DynamicInvoke(45, 33));
            }

            //User u = new User();//for single cast
            //Mydelegate2 obj2 = new Mydelegate2(u.AcceptName);
            //Console.WriteLine(obj2.Invoke("ThinkQuotient"));
            //c.Add(20, 30);
        }

    }
}
