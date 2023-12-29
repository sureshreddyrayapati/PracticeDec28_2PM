using PracticeDec28_2PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec28OOPS
{
    //public class Parent2
    //{
    //    public Parent2()
    //    {
    //        Console.WriteLine("parent class no parameter constructor");
    //    }
    //    public Parent2(int x)
    //    {
    //        Console.WriteLine("parent class overloaded constructor " + x);
    //    }
    //    static Parent2() { Console.WriteLine("parent class static constructor"); }
    //}//end of parent
    //public class Child2 : Parent2
    //{
    //    public Child2()
    //    {
    //        Console.WriteLine("child class no parameter constructor");
    //    }
    //    public Child2(int x)
    //    {
    //        Console.WriteLine("child class overloaded constructor " + x);
    //    }
    //    static Child2() { Console.WriteLine("child  class static constructor"); }
    //    static void Main(string[] args)
    //    {
    //        Child2 c1 = new Child2();
    //        Child2 c2 = new Child2(10);
    //    }
    //}


    class A
    {
       public  A()
        {
            Console.WriteLine("Hiii");
        }
       public A(int x) { Console.WriteLine(x); }
        public void M1()
        {
            Console.WriteLine("This is pareent class Method 1");
        }
         static A()
        {
            Console.WriteLine("This is static contructor");
        }
    }
    class B:A
    {
        B() :base(5)
        {
            Console.WriteLine("Defalt contructor");
        }
       
        public void M2(int x) 
        {
            base.M1();
            Console.WriteLine(x);
        }
        public static void Main(string[] args)
        {
            A a = new A();
            B x = new B();
            x.M2(4);
        }

    }

}

