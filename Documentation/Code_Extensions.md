# Code Extension

Within this library, there are a couple of code extension on Interfaces and .Net types. Whenever an input parameter has the keyword 'this' before it. then it refers to a [.Net Extension method](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)

- [Code Extension](#code-extension)
  - [Collection Extension](#collection-extension)
  - [Parallel](#parallel)
  - [Serialization](#serialization)
  - [Task Extension](#task-extension)
  - [Type Extension](#type-extension)

## Collection Extension

The additions upon arrays, IList, Lists, and ICollections

|Methods    |Description|Note   |
|-----------|-----------|-------|
|Contains<T>(this T[] Collection, T Value)  |Checks if an array contains the specified object   ||
|Contains<T>(this IList<T> Collection, T Value) |Checks if an list contains the specified object    ||
|Copy<T>(this List<T> values)   |Returns a copy of the whole list  |T must implement ICopyable  |
|Copy<T>(this T[] values)   |Returns a copy of the whole array  |T must implement ICopyable  |
|Copy<T>(this IList<T> values)  |Returns a copy of the whole list  |T must implement ICopyable  |
|Copy(this List<String> values)  |Returns a copy of the whole list  ||
|Copy(this String[] values)  |Returns a copy of the whole array  ||
|Replace<TCollection, TypeOld, TypeNew>(this TCollection[] Values, TypeOld Old, TypeNew New)    |Replaces value inside the array    |TCollection must implement IReplacable |
|Replace<TCollection, TypeOld, TypeNew>(this IList<TCollection> Values, TypeOld Old, TypeNew New)   |Replaces value inside the list |TCollection must implement IReplacable |
|Replace(this String[] Values, String Old, String New)  |Replaces value inside the array    |Values[I] = Values[I].Replace(Old, New);   |
|Replace(this IList<String> Values, String Old, String New)|Replaces value inside the list  |Values[I] = Values[I].Replace(Old, New);   |

## Parallel

Much like .Net System.Threading.Parallel allows for multi-threading over a collection of items. However, this version is aimed at a different approach and returns an array of tasks that can be waited for when the programmer wants.

The other big change is that by default, this Parallel function only creates tasks as many specified, or if none are specified, then a task is created per CPU core.
This change has been done because of the fact that continues creation, destructions, and starting of tasks are slowing done the processing time per item.
By simply dividing the array overall available cores, then each core will spend more of its operation time processing the array then creating, destroying, and starting tasks.

|Methods    |Description|
|-----------|-----------|
|ForEach<T>(T[] Items, Action<T> action)    |Loops over each item in the specified array    |
|ForEach<T>(T[] Items, Action<T> action, Int32 TaskCount)    |Loops over each item in the specified array    |
|ForEach<T, T1>(T[] Items, Action<T, T1> action, T1 Argument)    |Loops over each item in the specified array    |
|ForEach<T, T1>(T[] Items, Action<T, T1> action, T1 Argument, Int32 TaskCount)  |Loops over each item in the specified array    |
|ForEach<T>(ICollection<T>, Action<T> action)    |Loops over each item in the specified ICollection |
|ForEach<T>(ICollection<T>, Action<T> action, Int32 TaskCount)    |Loops over each item in the specified ICollection    |
|ForEach<T, T1>(ICollection<T>, Action<T, T1> action, T1 Argument)    |Loops over each item in the specified ICollection    |
|ForEach<T, T1>(ICollection<T>, Action<T, T1> action, T1 Argument, Int32 TaskCount)  |Loops over each item in the specified ICollection |

## Serialization

A static class has been written to create easy and quick serialization for all types of objects.
Under the namespace: DaanV2.Serialization. The functionality under the hood has a dictionary of serializing and deserializing factories. Each able to create serializers and deserializers upon request.

When using the class, a programmer usually never needs more than the following two methods:

|Methods    |Description|
|-----------|-----------|
|Serialize<T>(T O, String FactoryName, String Filepath)|Serializes the given object into the specified file using the specified factory |
|Deserialize<T>(String FactoryName, String Filepath)|Deserializes the given file into the specified object using the specified factory  |

The factory name uses specifies which factory to lookup from the internal dictionary. The following factories are already added(These are case sensitive):

* xml
* json

## Task Extension

|Methods    |Description|
|-----------|-----------|
|WaitAll(this Task[] Tasks) |Waits for all tasks to finish  |
|WaitAny(this Task[] Tasks) |Waits for any of the tasks to finish   |

## Type Extension

|Methods    |Description|
|-----------|-----------|
|ContainsInterface(this Type Object, Type Contains) |Checks if the given type implement the given interface type    |
|ContainsAttribute(this Type Object, Type Contains, Boolean Inherit = true) |Checks if the specified type contains a type of attribute  |
|GetAttribute(this Type Object, Type Value) |Returns the specified attribute    |
|GetAttribute<T>(this Type Object)  |Returns the specified attribute    |
|GetAttributes(this Type Object, Type Value)    |Returns the specified attributes   |
|GetAttributes<T>(this Type Object) |Returns the specified attributes   |
|GetObjectsWhichImplements(Type Contains)   |Returns a list of object that implements a specified type  |
|GetObjectsWhichImplements<T>() |Returns a list of object that implements a specified type  |
|GetObjectsWhichImplements(Type Contains, Assembly asm) |Returns a list of object that implements a specified type  |
|GetObjectsWhichImplements<T>(Assembly asm)|Returns a list of object that implements a specified type   |
|GetTypesWhichImplements(Type Implements)   |Returns a list of types that implement the specified implement |
|GetTypesWhichImplements(Type Implements, Assembly asm) |Returns a list of types that implement the specified implement  |
|Implements(this Type Value, Type Contains) |Check if the given type implements the specified type  |