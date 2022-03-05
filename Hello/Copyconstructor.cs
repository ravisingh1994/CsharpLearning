using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Copyconstructor
    {
        int a;
        int b;
        public Copyconstructor(int c, int d)
        {
            this.a = c;
            this.b = d;
        }
        public Copyconstructor(Copyconstructor co)
        {
            a= co.a;
            b= co.b;
        }
        public void Display()
        {
            Console.WriteLine($"value of a is {a} and B is {b}");
        }
    }
    public class Constest
    {
        static void Main()
        {
            Copyconstructor cpy = new Copyconstructor(10, 20);
            cpy.Display();
            Copyconstructor cpy1=new Copyconstructor(30, 40);
            cpy1.Display();
            Copyconstructor cpy2 = new Copyconstructor(cpy);
            cpy2.Display();
        }
    }
}
