using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    class Seminar : Course
    {
        public Seminar(string title) : base(title)
        {
        }
        // methode moet nog aangepast worden
        public override uint CalculateWorkload()
        {
            return 20;
        }
    }
}
