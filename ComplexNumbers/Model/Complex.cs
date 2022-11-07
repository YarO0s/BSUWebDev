using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers.Model
{
	clas Complex
	{
		private float a;
		private float b;
		
		public Complex(float a, float b)
		{
			this.a = a;
			this.b = b;
		}
		
		public float A
		{
			set
			{
				a = value;
			}
			
			get
			{
				return a;
			}
		}
		
		public float getA()
		{
			return a;
		}
		
		public float setA(float a)
		{
			this.a = a;
		}
		
		public float getB()
		{
			return b;
		}
		
		public float setB(float b)
		{
			this.b = b;
		}
		}
	}
}