using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Student student=new Student(01,"rahul",Streams.mech);
            Console.WriteLine(student);

          Student s2 = new Student(02, "rohit", Streams.IT);
            Console.WriteLine(s2);
        }
    }
}
