using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint
{
	public class BaseClass { }

	public class Derived : BaseClass { }

	public class MyClass4<T> where T : BaseClass { }
}
