using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class TestClass
    {
        private int age = 14;
                
        public void sayHello()
        {
            Console.WriteLine("Hello world. I am here and I want to learn every day!");
            Console.WriteLine("I am the clone!");
            Console.WriteLine("Niklas' IQ > Papa's IQ");
            Console.ReadKey();
        }

        public void showAge()
        {
            Console.WriteLine(age);
        }
    }
}
