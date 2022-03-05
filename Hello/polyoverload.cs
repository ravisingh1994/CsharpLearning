using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class polyoverload
    {
        int a, b;
        public void add(int a,int b)
        {
            this.a = a;
            this.b = b;
            int sum = a + b;
            Console.WriteLine(sum);
        }
        public void add(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine(sum);
        }
    }
    class Math: polyoverload
    {
        public void wel()
        {
            Console.WriteLine("Welcome to the Calculater");

        }
        public void add(int a, int b, int c)
        {
            Console.WriteLine("welcome to Child class Method");
            int sum = a + b + c;
            Console.WriteLine(sum);
        }
    }
}
