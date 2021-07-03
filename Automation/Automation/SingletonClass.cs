using System;
using System.Collections.Generic;
using System.Text;
System.StackM

namespace Automation
{
    //Class having a ptivate constructor and
    //always returns same object when you want to instantiate the class
    //In singleton Design pattern, same single object is used throuth out entire framework

    class SingletonClass
    {

        public static SingletonClass singletonclass;

        private SingletonClass()
        {
            Console.WriteLine("Object has been instantiated");
        }

        public static SingletonClass GetSingleTnClass()
        {
            if (singletonclass == null)
            {
                singletonclass = new SingletonClass();
            }
            return singletonclass;

        }

    }

    class x 
        {
        public static void main(string[] args)
        {
            if() AccessViolationException.L
            
        }
    }
}
