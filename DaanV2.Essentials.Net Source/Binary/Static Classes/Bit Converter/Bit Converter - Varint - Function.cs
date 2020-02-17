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

namespace DaanV2.Binary {
    ///DOLATER <summary>add description for class: BitConverter</summary>
    public static partial class BitConverter {
        public static partial class Varint {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Value"></param>
            /// <returns></returns>
            public static Int32 ByteCount(UInt32 Value) {
                if (Value < 0b1000_0000) {
                    return 1;
                }
                else if (Value < 0b0100_0000_0000_0000) {
                    return 2;
                } 
                else if (Value < 0b0010_0000_0000_0000_0000_0000) {
                    return 3;
                }
                else if (Value < 0b0001_0000_0000_0000_0000_0000_0000_0000) {
                    return 4;
                }

                return 5;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name=""></param>
            /// <returns></returns>
            public static Int32 ByteCount(UInt64 Value) {
                if (Value < 0b0000_0100_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000) {
                    if (Value < 0b1000_0000) {
                        return 1;
                    }
                    else if (Value < 0b0100_0000_0000_0000) {
                        return 2;
                    }
                    else if (Value < 0b0010_0000_0000_0000_0000_0000) {
                        return 3;
                    }
                    else if (Value < 0b0001_0000_0000_0000_0000_0000_0000_0000) {
                        return 4;
                    }
                    else if (Value < 0b0000_1000_0000_0000_0000_0000_0000_0000_0000_0000) {
                        return 5;
                    }
                }
                else {
                    if (Value < 0b0000_0100_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000) {
                        return 6;
                    }
                    else if (Value < 0b0000_0010_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000) {
                        return 7;
                    }
                    else if (Value < 0b0000_0001_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000) {
                        return 8;
                    }
                    else if (Value < 0b1000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000_0000) {
                        return 9;
                    }
                }

                return 10;
            }
        }
    }
}