using System.Collections;
using System.Collections.Generic;

namespace T2008m.sesson1
{
    public class Program
    {
        public static void main(string[] args)
        {
            Student s = new Student();
            s.name = "quang anh";
            Student.sname = "t2008m";
            ArrayList arrList = new ArrayList();
            arrList.Add("aa");
            arrList.Add(1);
            List<Student> students = new List<Student>();
            students.Add(s);
            List<int> ints = new List<int>();
            ints.Add(4);
            ints.Add(1);
        }
    }
}