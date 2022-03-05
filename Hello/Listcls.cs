using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Listcls
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(600);
            list.Add(3900);
            list.Add(1000);
            
            Console.WriteLine(list.Contains(400));// this method return bool value if the element present in the list
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After add Range Method ");
            list.AddRange(list);// it add list in the end of the list
            Console.WriteLine(list.BinarySearch(500));//it return the result of index present the particular element
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
