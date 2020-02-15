using System;
using System.IO;

namespace DaanV2.IO {
    ///DOLATER <summary>add description for class: StreamExtension</summary>
    public static partial class StreamExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static Int32 ReadLittleEndian(this Stream stream) {
            Int32 Out = 0;
            Int32 Length = sizeof(Int32);
            Byte[] Data = new Byte[Length];

            stream.Read(Data, 0, Length);

#if UNSAFE
            Int32 J = Length;

            unsafe {
                Byte* p = (Byte*)&Out;

                *p = Data[J--];

                for (Int32 I = 1; I < Length; I++) {
                    *(p + I) = Data[J--];
                }
            }
#else
            if (!BitConverter.IsLittleEndian) {
                Array.Reverse(Data);
            }

            Out = BitConverter.ToInt32(Data, 0);
#endif

            return Out;
        }
    }
}
