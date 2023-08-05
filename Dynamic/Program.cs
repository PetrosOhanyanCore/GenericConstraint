using Dynamic;
using static Dynamic.DynamicStatic;

dynamic variable = 1;
variable = "Hello world";
variable = DateTime.UtcNow;
variable = true;

Console.WriteLine(variable);
Console.WriteLine(variable.GetType());

Console.WriteLine(new string('-', 80));
Console.WriteLine(Dynamic.DynamicStatic.filed);
Console.WriteLine(Dynamic.DynamicStatic.filed.GetType());
Dynamic.DynamicStatic.filed = "Hello";
Console.WriteLine(Dynamic.DynamicStatic.filed);
Console.WriteLine(Dynamic.DynamicStatic.filed.GetType());
Console.WriteLine(new string('-', 90));


dynamic mYDelegate = new MethodDelegate(Dynamic.DynamicStatic.Method2);
dynamic @string = mYDelegate("Hello");

Console.WriteLine(@string);


dynamic myDelegate2 = new MyDelegate<dynamic, dynamic>(Method2);
dynamic someString = myDelegate2("World");
Console.WriteLine(someString);

Console.WriteLine(new string('-', 90));
dynamic My = new DynamicEvent();
My.MyEvent += new MyDelegate4(DynamicEvent.Handler);
My.Method("user", "admin");
My.MyEvent.Invoke("user", "admin");
