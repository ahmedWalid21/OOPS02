using OOPS02.Binding;
using OOPS02.Inheritance;
using OOPS02.overriding;

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
            static void EmployeeProcess(Empoyee e)
            {
                if(e is not null)
                {
                    e.fun1();
                    e.fun2();
                }
                
            }

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

            //3.2.polymorphism methods (functions) overriding
            //there are more than one function (in different class) these have same name 
            // and signature with different behaviour

            // TypeB b = new TypeB() { A = 12, B = 13 };
            // Console.WriteLine(b.A);
            //   Console.WriteLine(b.B);
            //  b.A = 12;
            // b.B = 13;
            //  b.fun1();
            //  b.fun2();

            //Binding
            // reference from parennt ----> object child

            //TypeA ref= new TypeA();
            // TypeA a;
            // a=new TypeA();
            // a=new TypeB();
            //child is a parent
            //  a.B = 12;
            // a.fun1(); //static bind method
            // a.fun2();//Binding

            //Not Binding

            //TypeB b=new TypeB();
            //  b = new TypeA();
            //child is parent
            // Animal--->Dog : Dog is Animal
            // Dog --> (Dog)Animal

            //TypeA Ref= new TypeA();
            // TypeB b = (TypeB)Ref;

            // when U need Binding

            //fullTime Employee id name address email salary
            fullTimeEmployee b = new fullTimeEmployee()
            {
                id = 1,
                name = "Ahmed",
                email = "ahmed.a.com",
                address = "cairo",
                salary = 12000


            };
            partTimeEmployee w = new partTimeEmployee()
            {
                id = 11,
                name = "Ali",
                email = "ali.a.com",
                address = "Alex",
                HourRate=300,
                NumberOfHour=200
            };

           // EmployeeProcess(w);
            //NullReferenceException
            





        }
    }
}
