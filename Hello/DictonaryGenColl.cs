using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class DictonaryGenColl
    {
        static void Main()
        {
            Dictionary<String, Object> dict = new Dictionary<String, Object>();
            dict.Add("Empid", 100);
            dict.Add("Name", "ravi");
            dict.Add("Email", "ravi@gmail.com");
            dict.Add("Phone", 9899561686);
            dict.Add("Add", "laxmanpur");
            dict.Add("Salary", 90000);
            //Console.WriteLine(dict.ContainsKey("Name")); // return the bool value for given particular keys
            //Console.WriteLine(dict.Count());// Return an intger vlaue for no of key value in Dictionary

            //Console.WriteLine(dict.Remove("Name"));// It will return true if the key is find to the Collection

            foreach(String key in dict.Keys)
            {
                Console.WriteLine(key +" : "+dict[key]);
            }
        }
    }
}
