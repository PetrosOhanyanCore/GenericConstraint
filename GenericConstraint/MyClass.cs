using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint
{
	public class MyClass<T> where T : class
	{
		public T variable;
	}

	public class MyClass2<T> where T : struct
	{
		public T variable;
	}
}
