using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Genricmethod1<T>
    {
        public void add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine((d1 + d2));
        }
        public void sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.Write((d1 - d2));
            Console.WriteLine();
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.Write((d1 * d2));
            Console.WriteLine();
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.Write((d1 / d2));
            Console.WriteLine();
        }
    }
        public class Genricclas1
        {
            static void Main()
            {
                Genricmethod1<int> gm = new Genricmethod1<int>();
                gm.add(10, 10);
                gm.sub(20, 30);
                gm.Mul(10, 20);
                gm.Div(30, 5);
                Console.ReadKey();
            }


        }
    
}
