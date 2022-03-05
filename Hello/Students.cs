using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Students //: IComparable<Students>
    {
        public int sid { get; set; }
        public string name { get; set; }

        public int age { get; set; }
        public int cls { get; set; }

        public static int ComapresNames(Students s1, Students s2)
        { return s1.name.CompareTo(s2.name); }


        //public int CompareTo(Students other)
        //{
        //    if (this.sid > other.sid)
        //    {
        //        return 1;
        //    }
        //    else if(this.sid<other.sid)
        //    {
        //        return -1;

        //    }
        //    else
        //        return 0;
        //}
    }
    //class Comparestudent : IComparer<Students>
    //{
    //    public int Compare(Students x, Students y)
    //    {
    //        if(x.age > y.age)
    //        {
    //            return 1;
    //        }
    //        else if(x.age<y.age)
    //        {
    //            return -1;
    //        }
    //        else
    //            return 0;
    //    }
    //}
    //class Mystudent : IComparer<Students>
    //{
    //    public int Compare(Students x, Students y)
    //    {
    //        if(x.cls>y.cls)
    //        {
    //            return 1;
    //        }
    //        else if(x.cls<y.cls)
    //            return -1;
    //        else
    //            return 0;
    //    }
    //}

    public class TestStudent
    {
        static void Main()
        {
           
            Students stu1 = new Students() { sid = 123, name = "Ravi", cls = 10, age = 22 };
            Students stu2 = new Students() { sid = 124, name = "Mohit", cls = 11, age = 23 };
            Students stu3 = new Students() { sid = 125, name = "Rani", cls = 12, age = 24 };
            Students stu4 = new Students() { sid = 127, name = "Shivi", cls = 6, age = 11 };
            Students stu5 = new Students() { sid = 128, name = "Banu", cls = 5, age = 8 };
            Students stu6 = new Students() { sid = 129, name = "Sani", cls = 13, age = 27 };

            List<Students> list = new List<Students>() { stu1, stu2, stu3, stu4, stu5, stu6 };
           // Comparestudent obj = new Comparestudent();
           // list.Sort(obj);
          // Mystudent my=new Mystudent();
           //list.Sort(my);
          // list.Sort(1,5,my);

           Comparison<Students> stu=new Comparison<Students>(Students.ComapresNames);
            list.Sort(stu);



            foreach(Students s in list)
            {
               Console.WriteLine($"Student Details are ID:{s.sid} Name is {s.name} With age {s.age} Study in Class {s.cls}");    
            }


        }
    }
}
