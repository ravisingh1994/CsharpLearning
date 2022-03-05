using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class EmployeeIEnumrable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public String job { get; set; }

    }
    public class EmployeeTest
    {
        public static void Main()
        {
            List<EmployeeIEnumrable> obj=new List<EmployeeIEnumrable>();
            obj.Add(new EmployeeIEnumrable
            {
                id = 11,
                name = "Ravi",
                salary = 24000,
                job ="manager"
            });
            obj.Add(new EmployeeIEnumrable
            {
                id = 13,
                name = "Sani",
                salary = 23000,
                job = "Police"
            });
            obj.Add(new EmployeeIEnumrable
            {
                id = 9,
                name = "Guddu",
                salary = 20000,
                job = "Sportman"
            });
            obj.Add(new EmployeeIEnumrable
            {
                id = 8,
                name = "Rani",
                salary = 26000,
                job = "Bank Officer"
            });

            obj.Add(new EmployeeIEnumrable
            {
                id = 10,
                name = "Udit",
                salary = 28000,
                job = "Store Manager"
            });

            foreach(EmployeeIEnumrable emp in obj)
            {
                Console.WriteLine(emp.id+ "  "+ emp.name+ "  "+emp.salary+ "  "+emp.job);
            }
        }
    }
}
