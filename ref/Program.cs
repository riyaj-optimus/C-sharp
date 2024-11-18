
//using System;
//using System.Collections.Generic;

//public class Example
//{
//    public static void Main()
//    {
//        Type type1 = typeof(Dictionary<,>);
//        Type type2 = typeof(Dictionary<int, string>);

//        Console.WriteLine($"Is {type1} a generic type definition? {type1.IsGenericTypeDefinition}");
//        Console.WriteLine($"Is {type2} a generic type definition? {type2.IsGenericTypeDefinition}");
//    }
//}
//using System;
//using System.Collections.Generic;

//public class Example
//{
//    public static void Main()
//    {
//        Type type1 = typeof(Dictionary<int, string>);
//        Type type2 = typeof(int);

//        Console.WriteLine($"Is {type1} a generic type? {type1.IsGenericType}");
//        Console.WriteLine($"Is {type2} a generic type? {type2.IsGenericType}");
//    }
//}

//using System;
//using System.Collections.Generic;

//public class Example
//{
//    public static void Main()
//    {
//        // Get the generic type definition
//        Type genericTypeDefinition = typeof(Dictionary<,>);

//        // Create a closed generic type
//        Type closedGenericType = genericTypeDefinition.MakeGenericType(typeof(int), typeof(string));

//        Console.WriteLine($"Closed generic type: {closedGenericType}");
//    }
//}


//using System;

//public class MyClass { }

//class Program
//{
//    static void Main()
//    {
//        // Step 1: Get the generic type definition of Dictionary<TKey, TValue>
//        Type openGenericType = typeof(Dictionary<,>); // Represents Dictionary<TKey, TValue>
//        Type genericTypeDefinition = openGenericType.GetGenericTypeDefinition();

//        // Step 2: Use MakeGenericType to specify the type parameters (int and MyClass)
//        Type closedGenericType = genericTypeDefinition.MakeGenericType(typeof(int), typeof(MyClass));

//        // Step 3: Create an instance of Dictionary<int, MyClass> using reflection
//        object dictionaryInstance = Activator.CreateInstance(closedGenericType);

//        // Step 4: Display the type of the created instance
//        Console.WriteLine(dictionaryInstance.GetType().FullName); // Outputs: System.Collections.Generic.Dictionary`2[System.Int32, MyClass]
//    }
//}



//public class Example
//{
//    public static void Main()
//    {
//       Type closed = typeof(Dictionary<int, string>);
//        Type[] argumentsOfGenericType = closed.GetGenericArguments();

//        foreach(Type t in argumentsOfGenericType)
//        {
//            Console.WriteLine(t);
//        }
//    }
//}


//public class Args
//{
//    public static void Main(string[] args)
//    {
//        Type ty = typeof(D<,>);
//        Type BaseType = ty.BaseType;  //this will return teh base class of D<>
//                                      //
//                                      //Console.WriteLine(BaseType);
//        if (BaseType == null)
//        {
//            Console.WriteLine("Base type is null.");
//            return;
//        }

//        Type[] generic = BaseType.GetGenericArguments();

//        foreach (Type ar in generic)
//        {
//            Console.WriteLine("Is Generic parameter :: " + ar.IsGenericParameter); //this code was throwing errror beacuse we are trying to access DeclaringMethod on a non f
//                                                                                            //

//            if (ar.IsGenericParameter)
//            {
//                Console.WriteLine("Position of the parameter is : " + ar.GenericParameterPosition);

//            }
//        }
//    }
//}

//class B<T, U> { }
//class D<V, W> : B<int, V> { }



//using System;
//using System.Collections.Generic;
//using System.Security.AccessControl;




//public class Args
//{
//    public static void Main(string[] args)
//    {
//        Type ty = typeof(D<,>);
//        Type BaseType = ty.BaseType;  //this will return teh base class of D<>

//                                      //Console.WriteLine(BaseType);
//        if (BaseType == null)
//        {
//            Console.WriteLine("Base type is null.");
//            return;
//        }

//        Type[] generic = BaseType.GetGenericArguments();

//        foreach (Type ar in generic)
//        {
//            Console.WriteLine("Is Generic parameter :: " + ar.IsGenericParameter);
//            Console.WriteLine("Source of the parameter is Type : " + ar.DeclaringType);
//            Console.WriteLine("source of the parameter is Method : " + ar.DeclaringMethod); //this code was throwing errror beacuse we are trying to access DeclaringMethod on a non f
//                                                                                            //

//            if (ar.IsGenericParameter)
//            {
//                Console.WriteLine("Position of the parameter is : " + ar.GenericParameterPosition);

//            }
//        }
//    }
//}

//class B<T, U> { }
//class D<V, W> : B<int, V> { }



using System;
using System.Reflection;

public class SomeClass { }

public interface IMyInterface { }

public class MyClass<T> where T : SomeClass, IMyInterface
{
    // T is constrained by SomeClass and IMyInterface
}

class Program
{
    public static void Main()
    {
        Type type = typeof(MyClass<>);  // This represents MyClass<T> (open generic)

     
        Type[] typeParams = type.GetGenericArguments();

     
        Type genericParam = typeParams[0];

        Type[] constraints = genericParam.GetGenericParameterConstraints();

        // Display the constraints
        Console.WriteLine($"Constraints on {genericParam.Name}:");
        foreach (Type constraint in constraints)
        {
            Console.WriteLine($"- {constraint.Name}");
        }
    }
}
