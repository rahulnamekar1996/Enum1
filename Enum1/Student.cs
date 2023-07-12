using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1
{
    public enum Streams { cs, IT,mech,electronics,civil }
   

    internal class Student
    {
        public int Id;
        public string Name;
        public int rollno;
        public static int count;
        private Streams stream;
        public Student(int rollno, string name, Streams stream)
        {
            count++;
            this.rollno = rollno;
            this.Name = name;
            this.Id = count;
            this.stream = stream;

        }
        public static int GetCount()
        {
            return count;
        }
        public override string ToString()
        {
            return $"name is {Name} roll no{rollno} id is{Id} stream{stream}";
        }

    }
}
