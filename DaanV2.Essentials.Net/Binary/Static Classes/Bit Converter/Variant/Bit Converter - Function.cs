/*ISC License

Copyright(c) 2019, Daan Verstraten, daanverstraten@hotmail.com*/
using System;

namespace DaanV2.Binary {
    
    public static partial class BitConverter {
        public static partial class Varint {

            /// <summary>Check the amount of bytes that are needed to store the given value</summary>
            /// <param name="Value">The object to check</param>
            /// <returns>Check the amount of bytes that are needed to store the given value</returns>
            public static Int32 ByteCount(Int32 Value) {
                return ByteCount((UInt32)Value);
            }

            /// <summary>Check the amount of bytes that are needed to store the given value</summary>
            /// <param name="Value">The object to check</param>
            /// <returns>Check the amount of bytes that are needed to store the given value</returns>
            public static Int32 ByteCount(Int64 Value) {
                return ByteCount((UInt64)Value);
            }

            /// <summary>Check the amount of bytes that are needed to store the given value</summary>
            /// <param name="Value">The object to check</param>
            /// <returns>Check the amount of bytes that are needed to store the given value</returns>
            public static Int32 ByteCount(UInt32 Value) {
                if (Value < 0b1000_0000) {
                    return 1;
                }
                else if (Value < 0b0100_0000_0000_0000ul) {
                    return 2;
                } 
                else if (Value < 0b0010_0000_0000_0000_0000_0000ul) {
                    return 3;
                }
                else if (Value < 0b0001_0000_0000_0000_0000_0000_0000_0000ul) {
                    return 4;
                }

                return 5;
            }

            /// <summary>Check the amount of bytes that are needed to store the given value</summary>
            /// <param name="Value">The object to check</param>
            /// <returns>Check the amount of bytes that are needed to store the given value</returns>
            public static Int32 ByteCount(UInt64 Value) {
                //Binary tree functionallity, if below then it must be 1 to 5 bytes, if above, then it must be 6 to 10 bytes
                if (Value < 0b0000_0100_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000ul) {
                    if (Value < 0b1000_0000ul) {
                        return 1;
                    }
                    else if (Value < 0b0100_0000_0000_0000ul) {
                        return 2;
                    }
                    else if (Value < 0b0010_0000_0000_0000_0000_0000ul) {
                        return 3;
                    }
                    else if (Value < 0b0001_0000_0000_0000_0000_0000_0000_0000ul) {
                        return 4;
                    }
                    else if (Value < 0b0000_1000_0000_0000_0000_0000_0000_0000_0000_0000ul) {
                        return 5;
                    }
                }
                else {
                    if (Value < 0b0000_0100_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000ul) {
                        return 6;
                    }
                    else if (Value < 0b0000_0010_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000ul) {
                        return 7;
                    }
                    else if (Value < 0b0000_0001_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000ul) {
                        return 8;
                    }
                    else if (Value < 0b1000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000ul) {
                        return 9;
                    }
                }

                return 10;
            }

        }
    }
}
