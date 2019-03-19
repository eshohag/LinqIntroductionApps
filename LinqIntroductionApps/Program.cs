using System;
using System.Collections.Generic;

namespace LinqIntroductionApps
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student collection
            IList<Student> studentListFromDatabase = new List<Student>() {
                new Student() { StudentId = 1, FullName = "John Doe", Age = 13} ,
                new Student() { StudentId = 2, FullName = "Shakil Khan",  Age = 21 } ,
                new Student() { StudentId = 3, FullName = "Imrul Kayes",  Age = 18 } ,
                new Student() { StudentId = 4, FullName = "Sakib Al Hassan" , Age = 20}
            };

            //var aStudent = (from student in studentListFromDatabase
            //                where student.StudentId == 2
            //                select student).FirstOrDefault();
            //Console.WriteLine(aStudent.StudentId + " Full Name- " + aStudent.FullName);

            //var aStudent = from student in studentListFromDatabase
            //               where student.StudentId == 2
            //               select student;
            //foreach (Student student in aStudent)
            //{
            //    Console.WriteLine(student.StudentId + " Full Name- " + student.FullName);
            //}

            //var aStudent = studentListFromDatabase.FirstOrDefault(a => a.StudentId == 2);

            //var aStudent = (from student in studentListFromDatabase
            //                where student.StudentId == 2
            //                select new { Id = student.StudentId, Name = student.FullName, Age = student.Age }).FirstOrDefault();
            //Console.WriteLine(aStudent.Name);

            //var aStudent = studentListFromDatabase.Where(a => a.StudentId == 2)
            //    .Select(a => new { Name = a.FullName, Id = a.StudentId, Age = a.Age }).FirstOrDefault();
            //Console.WriteLine(aStudent.Name);

            //var aStudent = studentListFromDatabase.Any(a => a.StudentId == 2);
            //Console.WriteLine(aStudent);

            //var aStudent = studentListFromDatabase.Count;
            //Console.WriteLine($"Total Number of Student-{aStudent}");

            studentListFromDatabase.Add(new Student() { StudentId = 5, FullName = "Muskier Brahmin", Age = 13 });
            //db.SaveChange();           //For LINQ Query Execution into database
            var aStudentCount = studentListFromDatabase.Count;
            Console.WriteLine($"Total Number of Students after Adding- {aStudentCount}");

            studentListFromDatabase.Insert(5, new Student() { StudentId = 6, FullName = "Musfiqur Rahmim", Age = 13 });
            var aStudent = studentListFromDatabase.Count;
            Console.WriteLine($"Total Number of Students after inserting- {aStudent}");

            Console.ReadKey();
        }
    }
}