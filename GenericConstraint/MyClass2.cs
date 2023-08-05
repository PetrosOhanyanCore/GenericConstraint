using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint
{
	public class MyClass3<T> where T : new()
	{
		public T instance = new T();
		public void GetValues()
		{
			Console.WriteLine(instance.ToString());
		}
	}

	public class TestClass
	{
		public int MyPropertyInt { get; set; }
		public string MyPropertyString { get; set; }

		public override string ToString()
		{
			return string.Format("{0} + {1}", MyPropertyInt, MyPropertyString);
		}
	}
}
