using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.Inheritance
{
    internal class Parent
    {
        public int x {  get; set; }
        public int y { get; set; }




        public void fun1()
        {
            Console.WriteLine("i'm parent [base]");
        }
        public void fun2()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"X: {x}  , Y: {y}"; 
        }








    }
}
