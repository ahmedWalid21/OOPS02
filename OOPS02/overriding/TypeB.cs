using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.overriding
{
    internal class TypeB: TypeA
    {
        //override or hide
        //override apply
        //apply override using"new" keyword
        //apply override using"override" keyword
       public int B {  get; set; }

        public new  void fun1()
        {
            Console.WriteLine("fun1 from typeB");
        }
        //must be not private and virtaul

        //dynamic binding
        //CLR will bind function call based on object type not reference type
        public override void fun2()
        {
            Console.WriteLine($"A: {A}, B: {B}");
        }









    }
}
