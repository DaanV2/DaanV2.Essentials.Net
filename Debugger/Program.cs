using System;
using System.Diagnostics;

namespace Debugger {
    internal class Program {
        private static void Main(String[] args) {
            

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
