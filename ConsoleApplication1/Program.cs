using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var b = new A.B();
            Console.WriteLine(b.GetValue());
            Console.WriteLine(b.ToString());
            var c = new C();
            
        }
    }
    public class A
    {
        private int value = 10;
        public class B: A
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }

    public class C: A
    {
        public int GetValue()
        {
            return 0;
        }
    }
}
