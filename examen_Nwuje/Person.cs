using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    abstract class Person
    {
        // PROPERTIES
        public string FirstName { get; set; }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    lastName = "niets ingegeven";
                }
                else
                {
                    lastName = value;
                }
            }
        }

        protected DateTime Birthday { get; set; }
        public int Id { get; set; }
        public int SchoolId { get; set; }
        protected string ContactNumber { get; set; }

        public Person()
        {

        }
        public Person(string firstName, string lastName, DateTime birthday, int id, int schoolId, string contactNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
            this.Id = id;
            this.SchoolId = schoolId;
            this.ContactNumber = contactNumber;
        }

        // METHODEN
        public abstract string ShowOne();

        public virtual string GetNameTagText()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
