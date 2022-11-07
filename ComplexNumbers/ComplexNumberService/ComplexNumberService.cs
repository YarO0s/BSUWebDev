using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers.Service
{
	class ComplexNumberService
	{
		public Model.Complex findSum(Model.Complex arg1, Model.Complex arg2)
		{
			float num1 = arg1.getA() + arg2.getA();
			float num2 = arg1.getB() + arg2.getB();
			return new Model.Complex(num1, num2);
		}
		
		public Model.Complex findSubtract(Model.Complex arg1, Model.Complex arg2)
		{
			float num1 = arg1.getA() - arg2.getA();
			float num2 = arg1.getB() - arg2.getB();
			return new Model.Complex(num1, num2);
		}
	}
}