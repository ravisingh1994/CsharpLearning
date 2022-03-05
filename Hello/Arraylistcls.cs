using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class Arraylistcls
    {
       
            static void Main(string[] args)
        {
            ArrayList arr=new ArrayList();
            arr.Add(100);
           arr.Add(("ravi"));
            arr.Add(200);
            arr.Add(300);
            arr.Add(500);
            arr.Add(600);
            foreach(object i in arr)
                Console.WriteLine(i);
            // properties of the ArrayList - Non Genric Collection
            Console.WriteLine(arr.Capacity); // it will return the capacity of the arraylist
            Console.WriteLine(arr.Count);// it will return the no of element present in arrayList
            Console.WriteLine(arr.IsFixedSize); // it return true if arraylist size is fixed
            Console.WriteLine(arr[2]);
            // Method of A ArrayList


            Console.ReadLine();

           
        }
    }
}
