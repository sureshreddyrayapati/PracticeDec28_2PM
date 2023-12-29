using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec28_2PM
{
    internal class hierarichal
    {
        class A 
        {
            public static double amount =1000.0;
            public double Deposite() 
            {
                Console.WriteLine("Enter Amount");
                double a= Convert.ToDouble(Console.ReadLine());
                amount = amount + a;
                return amount;
            }
            public double WithDraw()
            {
                Console.WriteLine("Enter Amount");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a <= 499)
                {
                    Console.WriteLine("Enter Minumim 500");
                   WithDraw();
                }
                else
                {
                    amount = amount - a;
                }
                return amount;  
            }
        }
        class Customer1 : A
        {
            public static void Main(string[] args) 
            {
                Console.WriteLine("Welcome to national Bank");
                Customer1 c = new Customer1();
                Console.WriteLine("1.Deposit\n2.WithDraw\n3.Available balence");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 3)
                {
                    Console.WriteLine(A.amount);
                }
                else if (n == 1)
                {
                    Console.WriteLine("Total amount= "+c.Deposite()) ;
                }
                else if (n == 2)
                {
                    Console.WriteLine("Total amount= " + c.WithDraw());
                }
                else
                {
                    Console.WriteLine("invalid option");
                    Main(args);
                }
            }
        }
        class Customer2 : A
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to national Bank");
                Customer2 c = new Customer2();
                Console.WriteLine("1.Deposit\n2.WithDraw\n3.Available balence");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 3)
                {
                    Console.WriteLine(A.amount);
                }
                else if (n == 1)
                {
                    Console.WriteLine("Total amount= " + c.Deposite());
                }
                else if (n == 2)
                {
                    Console.WriteLine("Total amount= " + c.WithDraw());
                }
                else
                {
                    Console.WriteLine("invalid option");
                    Main(args);
                }
            }
        }
        class Customer3 : A
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to national Bank");
                Customer3 c = new Customer3();
                Console.WriteLine("1.Deposit\n2.WithDraw\n3.Available balence");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 3)
                {
                    Console.WriteLine(A.amount);
                }
                else if (n == 1)
                {
                    Console.WriteLine("Total amount= " + c.Deposite());
                }
                else if (n == 2)
                {
                    Console.WriteLine("Total amount= " + c.WithDraw());
                }
                else
                {
                    Console.WriteLine("invalid option");
                    Main(args);
                }
            }
        }

    }
}
