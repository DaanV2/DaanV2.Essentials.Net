/*ISC License

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
using System.Collections.Generic;

namespace DaanV2.Serialization {
    public partial class SerializerAttribute : IEquatable<SerializerAttribute> {

        /// <summary>When implemented in a derived class, gets a unique identifier for this attribute</summary>
        public override Object TypeId => base.TypeId;

        /// <summary>Returns a value that indicates whether this instance is equal to a specified object</summary>
        /// <param name="obj">The object to check against</param>
        /// <returns>Returns a value that indicates whether this instance is equal to a specified object</returns>
        public override Boolean Equals(Object obj) {
            return obj is SerializerAttribute SA ? SA._FactoryName == this._FactoryName : base.Equals(obj);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <returns></returns>
        public override Boolean IsDefaultAttribute() {
            return String.IsNullOrEmpty(this._FactoryName);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="obj"></param>
        ///DOLATER <returns></returns>
        public override Boolean Match(Object obj) {
            return obj is SerializerAttribute SA ? SA._FactoryName == this._FactoryName : base.Match(obj);
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <returns></returns>
        public override String ToString() {
            return $"Deserializer: {this._FactoryName}";
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="other"></param>
        ///DOLATER <returns></returns>
        public Boolean Equals(SerializerAttribute other) {
            return other != null && this._FactoryName == other._FactoryName;
        }

        ///DOLATER <summary>Add Description</summary>
        ///DOLATER <returns></returns>
        public override Int32 GetHashCode() {
            Int32 hashCode = 1112600100;
            hashCode = (hashCode * -1521134295) + base.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<String>.Default.GetHashCode(this.FactoryName);
            return hashCode;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        ///DOLATER <returns></returns>
        public static Boolean operator ==(SerializerAttribute left, SerializerAttribute right) {
            Boolean L = left is Object;
            Boolean R = right is Object;

            if (L == R) {
                return L ? left.FactoryName == right.FactoryName : true;
            }

            return false;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        ///DOLATER <returns></returns>
        public static Boolean operator !=(SerializerAttribute left, SerializerAttribute right) {
            Boolean L = left is Object;
            Boolean R = right is Object;

            if (L == R) {
                return L ? left.FactoryName != right.FactoryName : false;
            }

            return true;
        }
    }
}
