﻿/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.


THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS.IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Runtime.Serialization;

namespace DaanV2 {
    /// <summary> add description for class: PriorityAttribute</summary>
	[Serializable, DataContract]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public partial class PriorityAttribute : Attribute {
        /// <summary>Creates a new instance of <see cref="PriorityAttribute"/></summary>
        public PriorityAttribute() {
            this.Value = 0;
        }

        /// <summary>Creates a new instance of <see cref="PriorityAttribute"/></summary>
        /// <param name="Value">The value to assign</param>
        public PriorityAttribute(Int32 Value) {
            this.Value = Value;
        }
    }
}