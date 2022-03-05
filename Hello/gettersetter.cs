using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class gettersetter
    {
        string name;
        string add;
        string job;
        public string getdata
        {
            set
            {
                name = value;
                add = value;
                job = value;
            }
            get
            {
                return name;
                return add;
                return job;
            }
        }
    }
}
