using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolAdminExamen
{
    class School
    {
		// PROPERTIES
		private string name;
		public string Name
		{
			get { return name; }
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					name = "niets ingegeven";
				}
				else
				{
					name = value;
				}
			}
		}

		public string Street { get; set; }
		public string PostalCode { get; set; }
		public string City { get; set; }
		public int Id { get; set; }
		public static List<School> List { get; set; }

		public School(string name, string street, string postalCode, string city, int id)
		{
			this.Name = name;
			this.Street = street;
			this.PostalCode = postalCode;
			this.City = city;
			this.Id = id;
		}

		// METHODEN
		public static string ShowAll()
		{
			string text = "Lijst van scholen: \n";
			foreach (var school in List)
			{
				text += $"{school.Name}, {school.Street}, {school.City}, {school.Id};\n";
			}
			return text;
		}
		public string ShowOne()
		{
			string text = $"Gegevens van de school: {this.Name}, {this.Street}, {this.City}, {this.Id}.";
			return text;
		}

	}
}
