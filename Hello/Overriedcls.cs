using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Overriedcls
    {
        protected String name;
        protected String add;
        public virtual void  Hus()
        {
            Console.WriteLine(" Welcome to Hus Class Matheod");
        }
    }
    class Wife: Overriedcls
    {
        public String wname;
        public override void Hus()
        {
            Console.WriteLine(" U R in Wife Class ");
            this.name = "Ravi";
            this.add = "Laxmanpur";
            this.wname = "Shivi";
            Console.WriteLine($"My Name Is {name} i'm From {add} my Wife is {wname}");
        }
    }
}
