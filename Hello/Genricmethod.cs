using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Genricmethod
    {
        public bool compare1<T>(T a,T b)
        {
            if(a.Equals(b))
                return true;
            return false;

        }
        
          static void Main(string[] args)
        {
            Genricmethod GM=new Genricmethod();
            bool res=GM.compare1<int>(10,30);
            bool res2 = GM.compare1<float>(20.21f, 20.21f);

            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }
}
