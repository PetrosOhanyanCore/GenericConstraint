using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
	public delegate dynamic MyDelegate4(dynamic sender, dynamic e);
	public class DynamicEvent
	{
		public dynamic MyEvent = default(dynamic);
		public dynamic Method(dynamic sender, dynamic e)
		{
			MyEvent.Invoke(sender, e);
			return default(dynamic);
		}

		public static dynamic Handler(dynamic sender, dynamic e)
		{
			Console.WriteLine(sender + " " + e);
			return default(dynamic);
		}
	}
}
