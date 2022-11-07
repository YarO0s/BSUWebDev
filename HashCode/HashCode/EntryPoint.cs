using HashCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    internal class EntryPoint
    {
        public static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit("bunny");
            Rabbit rabbit2 = new Rabbit("bunny2");

            Console.WriteLine(rabbit);
            Console.WriteLine(rabbit2);
        }
    }
}
