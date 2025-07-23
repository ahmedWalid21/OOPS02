using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.Binding
{
    internal class partTimeEmployee:Empoyee
    {
        public double HourRate { get; set; }

        public int NumberOfHour { get; set; }


        public new void fun1()
        {
            Console.WriteLine("i am part time Employee");
        }


        public override void fun2()
        {
            Console.WriteLine($"salary: {HourRate * NumberOfHour}" );
        }













    }
}
