using System;
using System.IO;

namespace Debugger {
    internal class Program {
        private static void Main(String[] args) {
            MemoryStream stream = new MemoryStream(new Byte[] { 0xAA, 0xBB, 0xCC, 0xDD });

            Int32 Out = 0;
            Int32 Length = sizeof(Int32);
            Byte[] Data = new Byte[Length];

            stream.Read(Data, 0, Length);
            unsafe {
                Byte* p = (Byte*)&Out;

                *p = Data[0];

                for (Int32 I = 1; I < Length; I++) {
                    *(p + I) = Data[I];
                }
            }
        }
    }
}
