using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.Binding
{
    internal class fullTimeEmployee: Empoyee
    {
        
        public double salary { get; set; }


        public new void fun1()
        {
            Console.WriteLine("i am full time Employee");
        }


        public override void fun2()
        {
            Console.WriteLine($"salary: {salary}");
        }




    }
}
