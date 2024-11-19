// event raise (add,key press,mouse move)>notification send to delegate,it hold method ref --> call that method, add method and run logic
//purpose- hold method ref and execute particular method
//we can create our own events and delegates manually when we working on console(in windows it is automatic)
//return type,parameter should be same

//Delegate is a reference type in C#
//Delegate is used to hold a method reference
//Delegate is also called as type safe pointer in C#
//There are two types of delegates	
//Single cast delegate  → One delegate hold one method reference
//Multicast delegate  → One delegate hold multiple method references

//Declaration of Delegates

//Access specifier   delegate-keyword return type delegate-name(parameters…)
//Method syntax & delegate syntax should be same  (syntax – return type, parameters)

//invocationList-holds order of methods(1.add,2.sub,3.mult)




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Program
    {
        // we will declare delegate in the namespace
        public delegate int MyDelegate(int x, int y);// variable name can be same or diff

        public delegate string Mydelegate2(string name);
        public class Calculator
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

        public class User
        {
            public string AcceptName(string name)
            {
                return name.ToUpper();
            }
        }
    }

}

