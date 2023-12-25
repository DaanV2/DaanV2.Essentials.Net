using System.Diagnostics;

namespace Debugger {
    internal class Program {
        private static void Main(String[] args) {
            Byte[] Data = new Byte[] { 0x00, 0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77 };

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