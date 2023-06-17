using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test {
    internal class Program {
        private static int x;
        public static void setX(int x1)
            {
            x = x1;

        }
        public static int getX() {
            return x;
        }

        static void Main(string[] args) {
            Console.WriteLine("Output = " + x);
        }
    }
}
