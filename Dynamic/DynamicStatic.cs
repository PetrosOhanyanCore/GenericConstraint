using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
	delegate R MyDelegate<T, R>(T argument);
	delegate dynamic MyDelegate3(dynamic sender, dynamic e);


	internal class DynamicStatic
	{
		public static dynamic filed = 1;

		int a = 5, b = 4, f = 6;

		dynamic field2 = 1, field3 = "SomeString", field4 = true;

		static dynamic Method(dynamic parameter)
		{
			return "Hello" + parameter;
		}

		public delegate dynamic MethodDelegate(dynamic parameter);
		public static dynamic Method2(dynamic parameter)
		{
			return parameter;
		}


		dynamic myEvent;

		//public event dynamic MyEvent
		//{
		//	add { myEvent += value; }
		//	remove { myEvent -= value; }
		//}

		public dynamic Method7(dynamic sender, dynamic e)
		{
			myEvent.Invoke(sender, e);
			return default(dynamic);
		}		
	}
}
