using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldWebAPI
{
   
    abstract class HelloWorldBase
    {
        public abstract void writeHelloWorld();
    }
    class HelloWorld : HelloWorldBase
    {
        public override void writeHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
    class HelloWorldImp
    {
        static void Main()
        {
            HelloWorldBase hwb = new HelloWorld();
            hwb.writeHelloWorld();
        }
    }

}