using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
	class EntryPoint
	{
		public static void Main(string[] args)
		{
			Service.ComplexNumberService complexNumberService = new Service.ComplexNumberService();
			Console.WriteLine(complexNumberService.findSum(new Model.Complex(1, 2), new Model.Complex(2, 1)));
		}
	}
}