using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class PrivateConstractor
    {
        private static int a;
        private PrivateConstractor()
        {
            a = 10;
        }
        public static void object1()
        {
            PrivateConstractor PC=new PrivateConstractor();
        }
        public static int getdeata()
        {
            return ++a;
        }
    }
    public class PrivateCons
    {
        static void Main()
        {
            PrivateConstractor.object1(); 
            Console.WriteLine(PrivateConstractor.getdeata());
        }
    }
}
