using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOPS02.Access_Modifiers
{
    internal class AccessModifiers
    {
        //Protected:1.  Accessible within the same class and derived classes.
        //2. Works even if the derived class is in a different project.
        //3.Not accessible from unrelated classes.


        //Private protected:1. Accessible only within the same class and derived classes,
        //2.But only if they are in the same assembly(project).
        //3. Not accessible from unrelated classes.
        //4.Not accessible from derived classes in another assembly.


        //internal protected:1. Accessible from: Any derived class (even in another assembly).
        //2.Any class within the same assembly, even if it's not derived.
        //3.It's the most flexible among the three in terms of accessibility.

    }
    class Parent
    {
        protected int x = 10;
        private protected int y = 20;
        protected internal int z = 30;
    }

    // ✅ Derived class in the same assembly (same project)
    class Child : Parent
    {
        public void ShowValues()
        {
            Console.WriteLine($"Child: x = {x}");  //  protected is accessible
            Console.WriteLine($"Child: y = {y}");  //  private protected is accessible
            Console.WriteLine($"Child: z = {z}");  //  protected internal is accessible
        }
    }

    //  Derived class simulating it's from another assembly
    class MiniChild : Parent
    {
        public void ShowValues()
        {
            Console.WriteLine($"MiniChild: x = {x}");  //  protected is accessible
            // Console.WriteLine($"MiniChild: y = {y}");  //  private protected NOT accessible from another assembly
            Console.WriteLine($"MiniChild: z = {z}");  //  protected internal is accessible
        }
    }

    // ❌ Not derived from Parent, but in the same project
    class Unrelated
    {
        public void ShowValues()
        {
            Parent p = new Parent();
            // Console.WriteLine(p.x); //  protected is not accessible
            // Console.WriteLine(p.y); //  private protected is not accessible
            Console.WriteLine($"Unrelated: z = {p.z}"); //  protected internal is accessible
        }


    }


    }





