using System;
using System.Diagnostics;

namespace Debugger {
    internal class Program {
        private static void Main(String[] args) {
            Byte[] Data = new Byte[] { 0xAA, 0xBB, 0xCC, 0xDD, 0xAA, 0xBB, 0xCC, 0xDD };
            Stopwatch sw = new Stopwatch();

            unsafe {
                for (Int32 I = 0; I < 10; I++) {

                    sw.Start();
                    for (Int32 J = 0; J < 10000000; J++) {
                        Int64 Out;
#if UNSAFE
                        unsafe {
                            Byte* d = (Byte*)&Out;

                            *d = Data[7];
                            *(d + 1) = Data[6];
                            *(d + 2) = Data[5];
                            *(d + 3) = Data[4];
                            *(d + 4) = Data[3];
                            *(d + 5) = Data[2];
                            *(d + 6) = Data[1];
                            *(d + 7) = Data[0];
                        }
#else
                        Out = Data[7];
                        Out |= ((Int64)Data[6] << 8);
                        Out |= ((Int64)Data[5] << 16);
                        Out |= ((Int64)Data[4] << 24);
                        Out |= ((Int64)Data[3] << 32);
                        Out |= ((Int64)Data[2] << 40);
                        Out |= ((Int64)Data[1] << 48);
                        Out |= ((Int64)Data[0] << 56);
#endif
                    }
                }
                sw.Stop();
            }

            Print(sw, 10 * 10000000);
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sw"></param>
        /// <param name=""></param>
        public static void Print(Stopwatch sw, Double ItemCount = 1) {
            Console.WriteLine("|Ms|Ticks|");
            Console.WriteLine("|---|---|");
            Console.WriteLine("|{0}|{1}|", sw.ElapsedMilliseconds, sw.ElapsedTicks);
            Console.WriteLine("|{0}|{1}|", sw.ElapsedMilliseconds / ItemCount, sw.ElapsedTicks / ItemCount);
        }
    }
}
