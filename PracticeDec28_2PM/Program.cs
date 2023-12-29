using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec28_2PM
{
     class Program
    {
       public void M1()
        {
            Console.WriteLine("Class 1");
        }
    }
    class A:Program
    {
       public  void M2()
        {
            base.M1();
            Console.WriteLine("Hiii");
        }
        static void Main(string[] args)
        {

            
            new A().M2 ();

        }
    }
}
