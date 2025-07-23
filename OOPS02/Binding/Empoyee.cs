using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS02.Binding
{
    internal class Empoyee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        


        public void fun1()
        {
            Console.WriteLine("i am Employee");
        }


        public  virtual void fun2()
        {
            Console.WriteLine($"salary: ???");
        }

















    }
}
