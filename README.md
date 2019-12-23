# Essentials

- [Essentials](#essentials)
  - [Builders](#builders)
  - [Compilers](#compilers)
  - [Converters](#converters)
  - [Processors](#processors)
  - [Serialization](#serialization)

This project is a base for all other projects to make sure they all have the same tools and interfaces, functions. The most important is the contract the interfaces this library gives.

[An overview of the contents of this API](./Documentation/Overview_Essentials.md)

## Builders

Builders are objects that can take a whole range of diFFerent objects or just a whole bunch of one type and put them together in a single specified object.

## Compilers

Compilers are objects that can take an object and convert to a form of machine code that is executed by a computer or emulating software.
Under the proper usage of a compiler is that it converts to machine code. But compilers can also be used to build other forms of executable codes.
Such as compile C# to batch code.
Decompilers are the opposite. They deconstruct executable code to a higher level of abstract.

## Converters

Converters are simply objects that convert from one type of object to another.

## Processors

Processors are objects that can process information in given objects. Such as resolving relative paths to absolute paths in config objects.

## Serialization

Serialization is the process of converting objects into a specified format. For example, a class saved as *.json file.
Deserializing is the opposite of this process.