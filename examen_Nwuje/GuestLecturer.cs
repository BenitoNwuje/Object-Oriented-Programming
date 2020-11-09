using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SchoolAdminExamen
{
    class GuestLecturer : Lecturer
    {
        //properties
        public string CompanyName { get; set; }
        public int HourlyFee { get; set; }
        //constructor
        public GuestLecturer(string firstName, string lastName, string companyName, int hourlyFee,DateTime birthday, int id, int schoolId, string contactNum):base(firstName, lastName, birthday, id,schoolId, contactNum)
        {
            this.CompanyName = companyName;
            this.HourlyFee = hourlyFee;
        }
        //method 
        public int CalculateFee(int numberOfHours)
        {

            return numberOfHours * this.HourlyFee;
        }
        public static string ShowAll(int lesUur)
        {
            string text = "Lijst van quest lectoren: \n";
            foreach (GuestLecturer quest in List)
            {
                text += $"{quest.FirstName}, {quest.LastName}, {quest.CompanyName}, {quest.CalculateFee(lesUur)}\n";
            }
            return text;
        }

        public string SaveToCsv()
        {
            string[] test = new string[2];
            int count = 0;
            foreach (GuestLecturer quest in List)
            {
                //Jeff, Leff, , Modern Ways, 1000, 12/01/1956, 1, 1, 0489000010
                string text = $"{quest.FirstName}, {quest.LastName}, {quest.CompanyName}, {quest.HourlyFee}, {quest.Birthday}, {quest.Id}, {quest.SchoolId},  {quest.ContactNumber}\n";
                test[count] = text;
                count++;
            }
            if (File.Exists("GuestLecturer.csv"))
            {
                File.WriteAllLines("GuestLecturer.csv", test);
                return "Bestand met de naam GuestLecturer.csv bestaat al";
            }
            else
            {
                File.WriteAllLines("GuestLecturer.csv", test);
                return "Bestand met de naam GuestLecturer.csv is gemaakt";
            }


        }

        public static void ReadFromCsv()
        {  
            Lecturer.List = new List<Lecturer>();
            string[] lines = File.ReadAllLines("GuestLecturer.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                GuestLecturer gast = new GuestLecturer("", "", "", 5, new DateTime(1, 1, 1), 0, 0, " ");
                string[] splitted = lines[i].Split(',');
                string[] element = new string[8];
                for (int j = 0; j < splitted.Length; j++)
                {
                    Console.WriteLine(splitted[j]);
                    element[j] = splitted[j];
                    switch (j)
                    {
                        case 0:
                            gast.FirstName = element[j];
                            break;
                        case 1:
                            gast.LastName = element[j];
                            break;
                        case 2:
                            gast.CompanyName = element[j];
                            break;
                        case 3:
                            gast.HourlyFee = int.Parse(element[j]);
                            break;
                        case 4:
                            gast.Birthday = DateTime.Parse(splitted[j]);
                            break;
                        case 5:
                            gast.Id = int.Parse(element[j]);
                            break;
                        case 6:
                            gast.SchoolId = int.Parse(element[j]);
                            break;
                        case 7:
                            gast.ContactNumber = element[j];
                            break;
                        default:
                            break;
                    }
                }
                if(gast.FirstName != "")
                {
                    List.Add(gast);
                }
            }
            Console.WriteLine(ShowAll(10));       
        }

    }
}
