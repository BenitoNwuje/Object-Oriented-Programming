using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    abstract class Course
    {
        public string Title { get; set; }

        public Course(string title)
        {
            this.Title = title;
        }

        public abstract uint CalculateWorkload();
    }
}
