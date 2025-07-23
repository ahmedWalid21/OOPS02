using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.Binding
{
    public class TypeA
    {

       public int A { get; set; }
        public new void fun1()
        {
            Console.WriteLine("fun1 from typeA");
        }

        public virtual void fun2()
        {
            Console.WriteLine($"A: {A}");
        }









    }
    public class TypeB : TypeA
    {

        public int B { get; set; }
        public new void fun1()
        {
            Console.WriteLine("fun1 from typeB");
        }

        public override void fun2()
        {
            Console.WriteLine($"A: {A}  B:{B}");
        }

    }

     public class TypeC : TypeB
    {

        public int C { get; set; }
        public new void fun1()
        {
            Console.WriteLine("fun1 from typeC");
        }

        public virtual void fun2()
        {
            Console.WriteLine($"A: {A}  B:{B}  , C:{C}");
        }

    }

    public class TypeD : TypeC
    {

        public int D { get; set; }
        public new  void fun1()
        {
            Console.WriteLine("fun1 from typeD");
        }

        public override void fun2()
        {
            Console.WriteLine($"A: {A}  , B:{B}  , C:{C}, D:{D}");
        }

    }

}
