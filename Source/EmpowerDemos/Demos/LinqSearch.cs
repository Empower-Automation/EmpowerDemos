using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerDemos.Demos
{
    class Student
    {
        public int StudentID = 1;
        public string StudentName = "John";
        public int Age = 18;
    } 

    class LinqSearch
    {

        public static void DemoWhere()
        {
            IList<Student> studentList = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
    };

            var filteredResult = studentList.Where(
                    s => s.Age > 12 && s.Age < 20
                );

            foreach (var std in filteredResult)
                Console.WriteLine(std.StudentName);
        }
    }
}
