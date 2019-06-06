# Essentials

## Builders
Builders are objects that can take a whole range of different objects or just a whole bunch of one type, and put them together in a single specified object.

## Compilers
Compilers are objects that can take a object and convert to a form of machine code that is executed by a computer or emulating software. 
Under the official usage of a compiler is that it converts to machine code. but compilers can also be used to build other forms of executable codes.
such as compile C# to batch code.
Decompilers are the opposite. They deconstruct executable code to a higher level of abstract.

## Processors
Processors are objects that can process information in given objects. such as resolving relative paths to absolutepaths in config objects.

## Serialization
Serialization is the process of converting objects into a specified format. for example, a class saved as *.json file.
Deserializing is the opposite of this process.

## Interfaces
A list of interfaces that can be found with this project. T is for the main generic type that can be processed, C for the context type.

- Builders
	- IBuilder<T>
	- IBuilder<T, C>
- Compilers
	- ICompiler<T>
	- ICompiler<T, C>
	- IDecompiler<T>
	- IDecompiler<T, C>
- Converters
	- IConverter<T>
	- IConverter<T, C>
	- IConverterInto<T>
	- IConverterInto<T, C>
- Processors
	- IProcessor<T>
	- IProcessor<T, C>
- Serialization
	- ISerializer<T>
	- ISerializer<T, C>
	- IDeserializer<T>
	- IDeserializer<T, C>