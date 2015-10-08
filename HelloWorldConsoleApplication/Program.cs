using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldWebAPI
{
    //Base Class
    abstract class HelloWorldBase
    {
        public abstract void writeHelloWorld();
    }

    //Derived class inheriting from base class
    class HelloWorld : HelloWorldBase
    {
        public override void writeHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
    //Main method
    class HelloWorldImp
    {
        static void Main()
        {
            HelloWorldBase hwb = new HelloWorld();
            hwb.writeHelloWorld();
        }
    }

}