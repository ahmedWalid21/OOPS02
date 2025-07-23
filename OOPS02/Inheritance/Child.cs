using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.Inheritance
{
    internal class Child : Parent
    {
        public int z {  get; set; }
        public Child(int x, int y, int z) : base(x,y)
        {
            this.z = z;

        }
        public override string ToString()
        {
            return $"X: {x},  Y: {y}, Z: {z}";
        }

        //override or hide
       public void fun1()
       {
            Console.WriteLine("i'm Child ");
        }
        public void fun2()
        {
            Console.WriteLine($"X: {x}, Y: {y}, Z: {z}");
        }











    }
}
