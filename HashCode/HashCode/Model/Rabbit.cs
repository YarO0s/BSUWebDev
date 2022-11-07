using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode.Model
{
    internal class Rabbit
    {
        private static long counter = 0;
        private long id = counter++;
        private string name;

        public Rabbit(string name) 
        {
            this.name = name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Rabbit:" + "id = " + this.id + "; name = " + this.name + "; HashCode = " + this.GetHashCode() + ".";
        }
    }
}
