using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Hashtablecls
    {
        public void hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "ravi");
            ht.Add("phone", 9899561686);
            ht.Add("eamil", "ravipratapsingh@gmail.com");
            ht.Add("add", "laxmanpur");
            ht.Add("distict", "basti");
            foreach (object key in ht.Keys)
                Console.WriteLine(key+":"+ ht[key]);
           //onsole.WriteLine(ht["eamil"]);
            
        }
    }
}
