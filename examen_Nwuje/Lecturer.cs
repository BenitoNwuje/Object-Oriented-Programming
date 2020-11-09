using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    class Lecturer : Person
    {
        // PROPERTIES
        public static List<Lecturer> List { get; set; }

        // Een List-property voor elke lecturer-object
        public List<Course> Courses { get; set; }

        public Lecturer() { }
        public Lecturer(string firstName, string lastName, DateTime birthday, int id, int schoolId, string contactNumber) 
            : base(firstName, lastName, birthday, id, schoolId, contactNumber)
        {
            this.Courses = new List<Course>();
        }

        // METHODEN
        public static string ShowAll()
        {
            string text = "Lijst van lectoren: \n";
            foreach (Lecturer lecturer in List)
            {
                text += $"{lecturer.FirstName}, {lecturer.LastName}, {lecturer.Birthday:yyyy-M-dd}, {lecturer.Id}, {lecturer.SchoolId};\n";
            }
            return text;
        }
        public override string ShowOne()
        {
            return $"Gegevens van de lector: {this.FirstName}, {this.LastName}, {this.Birthday:yyyy-M-dd}, {this.Id}, {this.SchoolId}.";
        }
        public string ShowTaughtCourses()
        {
            string result = $"Cursussen gegeven door de lector {this.FirstName}:\n";
            foreach (var course in this.Courses)
            {
                result += $"{course.Title} ({course.CalculateWorkload()})\n";
            }
            return result;
        }
        public override string GetNameTagText()
        {
            return $"(LECTOR) {this.FirstName} {this.LastName} ({this.ContactNumber})";
        }
    }
}
