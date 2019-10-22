# Interfaces

|Name|Description|
|------|------------|
|IBuilder\<T>|The inferface that is responsible for forming the contract between builders and output types|
|IBuilder<T, C>|The interface that responsible for building a specified class with/without context |
|ICompiler\<T>|The interface that is responsible for forming the contract on how compilers should behave|
|ICompiler<F, C>|The inferface responsible for forming the contract that tells how to compile an object with given context|
|IDecompiler\<T>|The interface responsible for forming the contract on how Decompilers should behave|
|IDecompilerContext|The interface responisble for forming the contract on how the Decompilers context should behave|
|IDeserializer<T, S>|The inferface that is responsible for forming the contract on how Deserializer should behave|
|IDeserializer<T, S, C>|The interface that is responisble for forming the contract on how Deserializer should behave|
|IConverter<T, T>|The interface responisble for forming the contract on how Converter should behave|
|IConverter<T, T, TypeContext>|The interface that is responsible for forming the contract on how Converters should behave|
|IConverterInto<T, T>|The interface responisble for forming the contract on how converters should behave|
|IConverterInto<T, T, TypeContext>|The interface responisble for forming the contract on how Converter should behave|
|IProcessor\<T>|The inferface responsible for forming the contract on how processor should behave|
|IProcessor<T, C>|The class for processing the information from a given type|
|ISerializer<T, S>|The interface that is responsible for forming the contract on how serializers should behave|
|ISerializer<T, S, C>|The interface that is responsible for forming the contract on how serializers should behave|
|ISerializerFactory\<T>|The interface responisble for form the contract on what a SerializerFactory should contain|
