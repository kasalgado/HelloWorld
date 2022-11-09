using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.counting();

            TestClass testClass = new TestClass();
            testClass.showAge();
            testClass.sayHello();                     
        }
    }
}
