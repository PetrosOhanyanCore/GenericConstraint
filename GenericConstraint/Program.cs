using GenericConstraint;

MyClass<string> instance = new MyClass<string>();

//MyClass<int> instance2 = new MyClass<int>(); ERROR

MyClass2<int> instance2 = new MyClass2<int>();
//MyClass2<string> instance3 = new MyClass2<string>(); ERROR

MyClass3<TestClass> instance3 = new MyClass3<TestClass>();
instance3.instance.MyPropertyInt = 1;
instance3.instance.MyPropertyString = "Hello world";
instance3.GetValues();


MyClass4<BaseClass> mc4 = new MyClass4<BaseClass>();

MyClass4<Derived> mc4D = new MyClass4<Derived>();




MyClass5<DerivedClass> mc5 = new MyClass5<DerivedClass>();
MyClass6<DerivedClass> mc6 = new MyClass6<DerivedClass>();

MyClass7<IInterface<object>> mc6D = new MyClass7<IInterface<object>>();

MyClass6<IInterface> myClass5 = new MyClass6<IInterface>();

MyClass8<int, object, int> myClass8 = new MyClass8<int, object, int>();

MyClass8<string, object, string> myClass81 = new MyClass8<string, object, string>();

MyClass8<string, int, dynamic> myClass82 = new MyClass8<string, int, object>();
