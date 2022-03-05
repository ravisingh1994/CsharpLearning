using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Coustomer
    {
        public int empid { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
    }

    public class Company
    {
        static void Main()
        {
            List<Coustomer> list = new List<Coustomer>();
            Coustomer c = new Coustomer() { name = "ravi", empid = 123, age = 18, salary = 50000 };
            Coustomer c1 = new Coustomer() { name = "amit", empid = 223, age = 98, salary = 40000 };
            Coustomer c2 = new Coustomer() { name = "Rohit", empid = 623, age = 68, salary = 60000 };
            Coustomer c3 = new Coustomer() { name = "Navi", empid = 723, age = 48, salary = 70000 };
            Coustomer c4 = new Coustomer() { name = "Gavi", empid = 423, age = 38, salary = 340000 };
            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            foreach(Coustomer obj in list)
            {
                Console.WriteLine($"Employee Details are Name Is {obj.name} and Emp Id Is {obj.empid} Eployee age is {obj.age} and getting salary is {obj.salary}");
            }
        }
    }

}
