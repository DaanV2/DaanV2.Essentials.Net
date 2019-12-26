# Interfaces

**Table of Contents**
- [Interfaces](#interfaces)
  - [Standard Interfaces](#standard-interfaces)
    - [General](#general)
    - [Builders](#builders)
    - [Compilers](#compilers)
    - [Converters](#converters)
    - [Processors](#processors)
    - [Serialization](#serialization)

## Standard Interfaces

### General

These interfaces are just for general use.

|Interface  |Description    |
|-----------|---------------|
|ICopyable<T>   |The interface responsible for forming on how an object needs to be copied, comes with extended code for collections   |
|IReplaceable<T>   |The interface responsible replacing the specified value with another, comes with extended code for collections    |
|IReplaceable<TypeOld, TypeNew> |The interface responsible replacing the specified value with another, comes with extended code for collections   |

### Builders

Builders are objects that can take a whole range of different objects or just a whole bunch of one specified type and put them together in a single specified object.

|Interface  |Description    |
|-----------|---------------|
|IBuilder<TypeToBuild, TIn>   |The inferface that is responsible for forming the contract between builders and output types |
|IBuilderContext<TypeToBuild, TIn, ContextType> |The interface that responsible for building a specified class with/without context |
|IBuilderAdd<TypeToAdd> |A subpart of an IBuilder<TypeToBuild, TIn> that specifies if a different object can be added  |
|IBuilderAddContext<TypeToAdd, ContextType> |A subpart of an IBuilder<TypeToBuild, TIn> that specifies if a different object can be added  |

### Compilers

Compilers are objects that can take an object and convert to a form of machine code that is executed by a computer or emulating software.
Under the proper usage of a compiler is that it converts to machine code. But compilers can also be used to build other forms of executable codes.
Such as compile C# to batch code. Decompilers are the opposite. They deconstruct executable code to a higher level of abstract.

|Interface  |Description    |
|-----------|---------------|
|ICompiler<TypeProcess> |The interface that is responsible for forming the contract on how compilers should transfer data between files and object  |
|ICompiler<TypeFrom, TypeContext>   |The interface that is responsible for forming the contract on how compilers should transfer data between files and object |
|ICompilerContext<ProcessObjectType>    |The interface responsible for forming the contract on how compiler context should be used  |
|IDecompiler<TypeTo>    |The interface responsible for forming the contract on how Decompilers should work    |
|IDecompiler<TypeTo, TypeContext>   |The interface responsible for forming the contract on how Decompilers should work    |
|IDecompilerContext |The interface responsible for forming the contract on how the Decompilers context should work be used    |
|IDecompilerInto<TReceiver, ContextType> |The interface that responsible for how a decompiler should work    |

### Converters

Converters are simply objects that convert from one type of object to another.

|Interface  |Description    |
|-----------|---------------|
|IConverter<TypeFrom, TypeTo>   |The interface responsible for forming the contract on how Converter should work  |
|IConverter<TypeFrom, TypeTo, TypeContext>  |The interface that is responsible for forming the contract on how Converters should work with context |
|IConverterInto<TypeFrom, TypeTo>   |The interface responsible for forming the contract on how converters should work |
|IConverterInto<TypeFrom, TypeTo, TypeContext>  |The interface responsible for forming the contract on how Converter should work with context |

### Processors

Processors are objects that can process information in given objects. Such as resolving relative paths to absolute paths in config objects.

|Interface  |Description    |
|-----------|---------------|
|IPostProcessor<T>  |The interface responsible for determining how post processors should work    |
|IPostProcessor<T, TypeContext> |The interface responsible for detereming how a post processor should work  |
|IPreProcessor<T>   |The interface responsible for determing how pre processor should work   |
|IPreProcessor<T, TypeContext>  |The interface responsible for forming the contract on how Pre processors should work  |
|IPostProcessorOut<TIn, TOut>  |The interface responsible for detereming how a post processor should work    |
|IPostProcessorOut<TIn, TOut, TypeContext> |The interface responsible for detereming how a post processor should work   |
|IPreProcessorOut<TIn, TOut>   |The interface responsible for determining how a Pre processor with output should work   |
|IPreProcessorOut<TIn, TOut, TypeContext>   |The interface responsible for detereming how a pre processor should work   |
|IDualProcessor<T>  |Implements both IPreProcessor<T> and IPostProcessor<T> |
|IDualProcessor<T, TypeContext> |Implements both IPreProcessor<T, TypeContext> and IPostProcessor<T, TypeContext>   |
|IDualProcessorOut<TIn, TOut>  |Implements both IPreProcessorOut<TIn, TOut> and IPostProcessorOut<TIn, TOut>    |
|IDualProcessorOut<TIn, TOut, TypeContext> |Implements both IPreProcessorOut<TIn, TOut, TypeContext> and IPostProcessorOut<TIn, TOut, TypeContext>  |

### Serialization

Serialization is the process of converting objects into a specified format. For example, a class saved as *.json file.
Deserializing is the opposite of this process.

|Interface  |Description    |
|-----------|---------------|
|IDeserializer<TypeOut, TypeStream> |The interface that is responsible for forming the contract on how Deserializer should work |
|IDeserializer<TypeOut, TypeStream, TypeContext>    |The interface that is responsible for forming the contract on how Deserializer should work |
|ISerializerFactory<TypeStream> |The interface responsible for the form the contract on what a SerializerFactory should contain, used by the serialization extension    |
|ISerializer<TypeIn, TypeStream>    |The interface that is responsible for forming the contract on how serializers should work  |
|ISerializer<TypeIn, TypeStream, TypeContext>   |The interface that is responsible for forming the contract on how serializers should work  |