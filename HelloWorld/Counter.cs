using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Counter
    {

        public void counting()
        {
            for(int x = 1; x < 11; x++)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
