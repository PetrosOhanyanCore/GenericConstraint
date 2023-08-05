using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint
{
	interface IInterface { }
	interface IInterface<T> { }

	public class DerivedClass : IInterface, IInterface<object>
	{

	}
	class MyClass5<T> where T : IInterface, IInterface<object>
	{

	}

	class MyClass6<T> where T : IInterface
	{

	}

	class MyClass7<T> where T : IInterface<object>
	{

	}

}
