using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    class Student : Person
    {
        // PROPERTIES
        public static List<Student> List { get; set; }
        public List<Course> Courses { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }


        public Student() {
        }

        public Student(string firstName, string lastName, DateTime birthday, int id, int schoolId, string contactNumber) 
            :base(firstName, lastName, birthday, id, schoolId, contactNumber) 
        {
            this.Courses = new List<Course>();
        }

        // METHODEN
        public static string ShowAll()
        {
            string text = "Lijst van studenten: \n";
            foreach (var student in List)
            {
                text += $"{student.FirstName}, {student.LastName}, {student.Birthday:yyyy-M-dd}, {student.Id}, {student.SchoolId};\n";
            }
            return text;
        }

        public override string ShowOne()
        {
            return $"Gegevens van de student: {this.FirstName}, {this.LastName}, {this.Birthday:yyyy-M-dd}, {this.Id}, {this.SchoolId}.";
        }

        public override string GetNameTagText()
        {
            return $"(STUDENT) {this.FirstName} {this.LastName} ({this.ContactNumber})";
        }

        public string ShowCourses()
        {
            string result = $"Cursussen gevolgt door de student {this.FirstName} {this.LastName}:\n";
            foreach (var course in this.Courses)
            {
                result += $"{course.Title} ({course.CalculateWorkload()})\n";
            }
            return result;
        }
        public static string ShowAllWithAge()
        {
            string text = "Lijst van studenten met hun leeftijd: \n";
            foreach (var student in List)
            {
                text += $"{student.FirstName}, {student.LastName} is {student.Age} jaar oud.;\n";
            }
            return text;
        }
        public static float CalculateAverageAge()
        {

            float averageAge = 0;
            float count = 0;
            foreach (var student in List)
            {
                averageAge += student.Age;
                count++;
            }
            return averageAge / count;
        }
        public float CalculateWorkload()
        {
            float workLoad = 0;
            foreach (var course in Courses)
            {
                workLoad += course.CalculateWorkload();
            }
            return workLoad;
        }
    }

}
