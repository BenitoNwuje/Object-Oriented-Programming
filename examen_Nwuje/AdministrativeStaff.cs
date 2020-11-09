using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    class AdministrativeStaff : Person
    {

        public AdministrativeStaff(string firstName, string lastName, DateTime birthday, int id, int schoolId, string contactNumber)
            : base (firstName, lastName, birthday, id, schoolId, contactNumber)
        {
        }
        public override string ShowOne()
        {
            return $"Gegevens van de administratieve medewerker: {this.FirstName}, {this.LastName}, {this.Id}, {this.SchoolId}.";
        }

        public override string GetNameTagText()
        {
            return $"(ADMINISTRATIEF PERSONEEL) {this.FirstName} {this.LastName} ({this.ContactNumber})";
        }
    }
}
