using System;
using System.Collections.Generic;

namespace DaanV2.Binary {
    public partial struct BitFlags8 {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Boolean> ToList() {
            return new List<Boolean> {
                this.Flag1,
                this.Flag2,
                this.Flag3,
                this.Flag4,
                this.Flag5,
                this.Flag6,
                this.Flag7,
                this.Flag8
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Boolean[] ToArray() {
            return new Boolean[8] {
                this.Flag1,
                this.Flag2,
                this.Flag3,
                this.Flag4,
                this.Flag5,
                this.Flag6,
                this.Flag7,
                this.Flag8
            };
        }
    }
}
