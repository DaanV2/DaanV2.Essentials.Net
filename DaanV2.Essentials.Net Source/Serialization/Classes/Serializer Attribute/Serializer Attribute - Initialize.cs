﻿/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Runtime.Serialization;

namespace DaanV2.Serialization {
    /// <summary>The attribute that marks a class that it is a serializer and what factory it belongs to.</summary>
	[Serializable, DataContract, AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public partial class SerializerAttribute : Attribute {

        /// <summary>Creates a new instance of <see cref="SerializerAttribute"/>.</summary>
        public SerializerAttribute() : this(String.Empty) { }

        /// <summary>Creates a new instance of <see cref="SerializerAttribute"/>.</summary>
        /// <param name="Name">The name of the factory.</param>
        public SerializerAttribute(String Name) {
            this.FactoryName = Name;
        }
    }
}
