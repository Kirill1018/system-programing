using System.Reflection;

//Type type = typeof (string);
//Console.WriteLine (type);

//MethodInfo[] methodInfos = type.GetMethods ();
//foreach (MethodInfo method in methodInfos)
//    Console.WriteLine (method);

//FieldInfo[] fields = type.GetFields (
//    BindingFlags.Public | BindingFlags.NonPublic
//    | BindingFlags.Instance | BindingFlags.Static);
//foreach (FieldInfo field in fields)
//    if (field.Name == "_firstChar") {
//        string hello = "Hello";
//        field.SetValue (hello, 'h');  // записать поле field в объекте "Hello"
//        char c = (char) field.GetValue (hello);  // прочитать поле field в объекте "Hello"
//        Console.WriteLine (c);
//    }

Assembly assembly = Assembly.LoadFrom ("Reflection_.dll");
Module module = assembly.GetModule ("Reflection_.dll");

foreach (Type type in module.GetTypes ())
    Console.WriteLine (type);
