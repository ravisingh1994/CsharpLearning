using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public abstract class student
    {
        public abstract int marks { get; set; }
    }
    public class pgstu:student
    {
        public override int marks { get; set; }

    }

    public class grastu : student
    {
        public override int marks { get; set; }

    }
    internal class Genriccls<T> where T : student
    {
        public T stu;
        public void printmarks()
        {
            student temp = (student)stu;
            Console.WriteLine(temp.marks);

        }

    }
    
}
