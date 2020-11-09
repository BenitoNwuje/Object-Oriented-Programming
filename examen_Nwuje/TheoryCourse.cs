using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    class TheoryCourse : Course
    {
        public byte StudyPoints { get; set; }

        public TheoryCourse(string title, byte studyPoints) : base(title)
        {
            this.StudyPoints = studyPoints;
        }

        public override uint CalculateWorkload()
        {
            return this.StudyPoints * (uint) 4;
        }
    }
}
