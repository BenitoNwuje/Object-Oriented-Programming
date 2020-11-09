using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    class LabCourse : Course
    {
        public byte StudyPoints { get; set; }
        public string Materials { get; set; }

        public LabCourse(string title) : base(title)
        {
            StudyPoints = 4;
        }
        public LabCourse(string title, byte studyPoints) : base(title)
        {
            this.StudyPoints = studyPoints;
        }
        // methode moet nog aangepast worden
        public override uint CalculateWorkload()
        {
            return this.StudyPoints * (uint) 2;
        }
    }
}
