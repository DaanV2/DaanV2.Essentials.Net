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

namespace DaanV2 {
    public partial class PriorityAttribute : IEquatable<PriorityAttribute> {
        /// <summary>When implemented in a derived class, gets a unique identifier for this attribute.</summary>
        public override Object TypeId => base.TypeId;

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="obj">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public override Boolean Equals(Object obj) {
            return obj is PriorityAttribute Pa ? Pa._Value == this._Value : base.Equals(obj);
        }

        /// <summary>Check if this attribute matches the specified <see cref="Object"/>.</summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>Check if this attribute matches the specified <see cref="Object"/>.</returns>
        public override Boolean Match(Object obj) {
            return obj is PriorityAttribute Pa ? Pa._Value == this._Value : base.Match(obj);
        }

        /// <summary>Returns a string that represents this object.</summary>
        /// <returns>Returns a string that represents this object.</returns>
        public override String ToString() {
            return $"priority: {this._Value}";
        }

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
        /// <param name="other">The object to check against.</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object.</returns>
        public Boolean Equals(PriorityAttribute other) {
            return other != null && this.Value == other.Value;
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>Returns the hash code for this instance.</returns>
        public override Int32 GetHashCode() {
#if NETCORE
            return HashCode.Combine(base.GetHashCode(), this.Value);
#else
            Int32 hashCode = -159790080;
            hashCode = (hashCode * -1521134295) + base.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.Value.GetHashCode();
            return hashCode;
#endif
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are equal to each other.</returns>
        public static Boolean operator ==(PriorityAttribute left, PriorityAttribute right) {
            return left._Value == right._Value;
        }

        /// <summary>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</summary>
        /// <param name="left">The first <see cref="PriorityAttribute"/> to check.</param>
        /// <param name="right">The second <see cref="PriorityAttribute"/> to check.</param>
        /// <returns>Compare two <see cref="PriorityAttribute"/> if they are not equal to each other.</returns>
        public static Boolean operator !=(PriorityAttribute left, PriorityAttribute right) {
            return left._Value != right._Value;
        }
    }
}
