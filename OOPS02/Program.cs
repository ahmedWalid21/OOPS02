using OOPS02.Inheritance;

namespace OOPS02
{
    internal class Program
    {
        static int sum(int x, int y)
        {
            return x + y;
        }
        static double sum(double x, double y)
        {
            return x + y;
        }
        static double sum(double x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {


            #region Inheritance
            // Parent p = new Parent(1, 2);
            // Console.WriteLine(p);
            // p.fun1();
            // p.fun2();

            //Child c = new Child(1, 2, 3);
            //Console.WriteLine(c);
            //c.fun1();
            //c.fun2();


            #endregion

            //3.polymorphism
            //3.1.polymorphism methods (functions) overloading
            //3.2.polymorphism methods (functions) overriding
            // Console.WriteLine();


            //3.1.polymorphism methods (functions) overloading {class , struct}
            // there are more than function have same Name but with different signutre
            //(count, type order) parameter


          //  sum(1, 2);
          //  sum(1.2, 3.4);



        }
    }
}
