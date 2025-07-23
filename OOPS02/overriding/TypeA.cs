using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.overriding
{
    internal class TypeA
    {

        public int A {  get; set; }

        public void fun1()
        {
            Console.WriteLine("fun1 from typeA");
        }

        public virtual void fun2()
        {
            Console.WriteLine($"A: {A}");
        }







    }
}
