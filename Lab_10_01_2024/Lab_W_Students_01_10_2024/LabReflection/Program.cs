
using System.Reflection;

string path = @"C:\Users\Asus\source\repos\LabReflection\LibraryForReflection\bin\Debug\net6.0\LibraryForReflection.dll";
Assembly asmb = Assembly.LoadFile(path);


Type? type = asmb.GetType("LibraryForReflection.TestClassForReflection");


if (type is not null)
{
    var obj = Activator.CreateInstance(type);

    /*MethodInfo? methodInfo = type.GetMethod("TestMethod",BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance |BindingFlags.Static);

    if(methodInfo is not null)
    {
        methodInfo.Invoke(obj,null);
    }*/

    /*PropertyInfo[] propertyInfos = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

    if (propertyInfos.Length > 0)
    {
        foreach (PropertyInfo propertyInfo in propertyInfos)
        {

            Console.WriteLine($"{propertyInfo.Name}'value: {propertyInfo.GetValue(obj)}"); 
        }
    }*/

    FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

    if (fieldInfos.Length > 0)
    {
        foreach (FieldInfo fieldInfo in fieldInfos)
        {

            Console.WriteLine($"{fieldInfo.Name}'value: {fieldInfo.GetValue(obj)}");
        }
    }

}

/*foreach (Type type in asmb.GetTypes())
{
    MethodInfo[] methodInfo = type.GetMethods();

    foreach(MethodInfo method in methodInfo)
    {
        Console.WriteLine(method.Name);
    }
}*/