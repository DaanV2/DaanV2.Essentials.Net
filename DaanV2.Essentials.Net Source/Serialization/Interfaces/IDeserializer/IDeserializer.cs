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

namespace DaanV2.Serialization {
    /// <summary>The interface that is responsible for forming the contract on how Deserializer should work.</summary>
    /// <typeparam name="TypeOut">The type that needs to be returned after deserializing.</typeparam>
    /// <typeparam name="TypeStream">The type that is used as the data stream.</typeparam>
    public interface IDeserializer<TypeOut, TypeStream> {
        /// <summary>Deserialize the given stream into the specified <see cref="Type"/>.</summary>
        /// <param name="Reader">The stream to read from.</param>
        /// <returns>Deserialize the given stream into the specified <see cref="Type"/>.</returns>
        TypeOut Deserialize(TypeStream Reader);
    }
}
