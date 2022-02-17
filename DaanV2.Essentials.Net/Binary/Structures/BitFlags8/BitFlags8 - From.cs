using System;
using System.Collections.Generic;

namespace DaanV2.Binary {
    public partial struct BitFlags8 {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BitFlags8 From(Boolean[] values) {
            return From(values.AsSpan());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BitFlags8 From(ReadOnlySpan<Boolean> values) {
            var Result = new BitFlags8();

            switch (values.Length) {
                case 0:
                    break;

                default:
                case 8:
                    Result.Flag8 = values[7];
                    goto case 7;

                case 7:
                    Result.Flag7 = values[6];
                    goto case 6;

                case 6:
                    Result.Flag6 = values[5];
                    goto case 5;

                case 5:
                    Result.Flag5 = values[4];
                    goto case 4;

                case 4:
                    Result.Flag4 = values[3];
                    goto case 3;

                case 3:
                    Result.Flag3 = values[2];
                    goto case 2;

                case 2:
                    Result.Flag2 = values[1];
                    goto case 1;

                case 1:
                    Result.Flag1 = values[0];
                    break;
            }


            return Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static BitFlags8 From(List<Boolean> values) {
            var Result = new BitFlags8();

            switch (values.Count) {
                case 0:
                    break;

                default:
                case 8:
                    Result.Flag8 = values[7];
                    goto case 7;

                case 7:
                    Result.Flag7 = values[6];
                    goto case 6;

                case 6:
                    Result.Flag6 = values[5];
                    goto case 5;

                case 5:
                    Result.Flag5 = values[4];
                    goto case 4;

                case 4:
                    Result.Flag4 = values[3];
                    goto case 3;

                case 3:
                    Result.Flag3 = values[2];
                    goto case 2;

                case 2:
                    Result.Flag2 = values[1];
                    goto case 1;

                case 1:
                    Result.Flag1 = values[0];
                    break;
            }

            return Result;
        }
    }
}
