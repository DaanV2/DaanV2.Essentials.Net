# Essentials

<p align="center">
  <a href="https://www.nuget.org/packages/DaanV2.Essentials.Net/">
    <img alt="Nuget" src="https://img.shields.io/nuget/v/DaanV2.Essentials.Net?style=for-the-badge">
    <img alt="Nuget" src="https://img.shields.io/nuget/dt/DaanV2.Essentials.Net?style=for-the-badge">
  </a>
</p>

This library provides a set of default interfaces and code extensions upon .Net to ease up programming.

- [Essentials](#essentials)
  - [Features Summary](#features-summary)
  - [Overview Essentials](#overview-essentials)
  - [Compiling](#compiling)

## Features Summary

* [Standard Interfaces for data handling.](./Documentation/Interfaces.md)
* [Collection Extensions](./Documentation/Code_Extensions.md##collection-extension)
  * Copy
  * Replace
  * Contains
* Bit Converter for Big/Little Endian
* Bit Converter for Varint
* [Parralel Multi-Threading](./Documentation/Code_Extensions.md##parallel)
* [Easy Serialization](./Documentation/Code_Extensions.md##serialization)
* [Stream extension](./Documentation/Code_Extensions.md##stream-extension)
* [Task Extension](./Documentation/Code_Extensions.md##task-extension)
* [Type Extension](./Documentation/Code_Extensions.md##type-extension)


## Overview Essentials

* [Interfaces](Interfaces.md)
  * The collection of interfaces and their purpose within this library.
* [Code Extension](Code_Extensions.md)
  * The collection of different addition on existing interfaces within the library and on .Net api itself.


## Compiling

If compiling for .Net core when added the source code directly, then add NETCORE to 'Conditional compilation symbols'. this can be found under 'Properties' -> 'Build'.

There is also an option to use faster but unsafe code. turn on allow safe code in the project and add UNSAFE to the 'Conditional compilation symbols'.