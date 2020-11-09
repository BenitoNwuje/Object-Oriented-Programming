using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SchoolAdminExamen
{
    class Program
    {
        static void UseSchoolAdminClasses()
        {
            Student sonjaF = new Student("Sonja", "Federici", new DateTime(1990, 12, 06), 2, 3, "0489000001");
            Student farahB = new Student("Farah", "Bhattacharya", new DateTime(1987, 12, 06), 1, 4, "0489000002");
            Student joelM = new Student("Joel", "Mokyr", new DateTime(1991, 12, 06), 1, 1, "0489000003");
            Student JulienS = new Student("Julien", "Schoenaerts", new DateTime(1971, 10, 21), 2, 1, "0489000004");
            Student.List = new List<Student>
            {

                sonjaF,
                farahB,
                joelM,
                JulienS
            };
            Lecturer cinziaA = new Lecturer("Cinzia", "Arruzza", new DateTime(1970, 10, 21), 2, 3, "0489000005");
            Lecturer raoulB = new Lecturer("Raoul", "Bauer", new DateTime(1947, 12, 06), 1, 4, "0489000006");
            Lecturer.List = new List<Lecturer>
            {
                cinziaA,
                raoulB
            };

            LabCourse labOop = new LabCourse("Labo 00 Programmeren", 6);
            LabCourse labWeb = new LabCourse("Labo Webtechnologie", 6);
            LabCourse labDat = new LabCourse("Labo Databanken", 4);
            LabCourse labItE = new LabCourse("Labo It-essentials", 4);

            TheoryCourse thOop = new TheoryCourse("Theorie OO Programmeren", 3);
            TheoryCourse thWeb = new TheoryCourse("Theorie Webtechnologie", 3);
            TheoryCourse thDat = new TheoryCourse("Theorie Databanken", 2);
            TheoryCourse thItE = new TheoryCourse("Theorie It-Essentials", 2);

            Seminar semRea = new Seminar("React");
            Seminar semSta = new Seminar("Static websites met Gatsby op Azure");

            joelM.Courses.Add(labOop);
            joelM.Courses.Add(thOop);
            joelM.Courses.Add(labWeb);
            joelM.Courses.Add(thWeb);
            joelM.Courses.Add(semRea);

            //Julien Schoenaerts volgt de vakken(theorie en labo) OO Programmeren en Databanken
            JulienS.Courses.Add(labOop);
            JulienS.Courses.Add(thOop);
            JulienS.Courses.Add(labDat);
            JulienS.Courses.Add(thDat);
            //3.Sonja Federici volgt de vakken(theorie en labo) Databanken en It - Essentials en het seminari Static websites met Gatsby op Azure
            sonjaF.Courses.Add(labItE);
            sonjaF.Courses.Add(thItE);
            sonjaF.Courses.Add(labDat);
            sonjaF.Courses.Add(thDat);
            sonjaF.Courses.Add(semSta);
            //4.Farah, Bhattacharya volgt de vakken(theorie en labo) Webtechnolgie en Databanken
            farahB.Courses.Add(thWeb);
            farahB.Courses.Add(labWeb);
            farahB.Courses.Add(labDat);
            farahB.Courses.Add(thDat);
            //Cinzia Arruzza geeft de vakken(theorie en labo) OO Programmeren en Webtechologie en het seminarie Static websites met Gatsby op Azure
            //2.Raoul Bauer geeft de vakken(theorie en labo) Databanken en It - Essentials en het seminarie React
            cinziaA.Courses.Add(thOop);
            cinziaA.Courses.Add(labOop);
            cinziaA.Courses.Add(thWeb);
            cinziaA.Courses.Add(labWeb);
            cinziaA.Courses.Add(semSta);
            raoulB.Courses.Add(thDat);
            raoulB.Courses.Add(labDat);
            raoulB.Courses.Add(thItE);
            raoulB.Courses.Add(labItE);
            raoulB.Courses.Add(semRea);

            
            
            foreach (var student in Student.List)
            {
                Console.WriteLine($"{student.ShowCourses()}");
            }
            foreach (var student in Student.List)
            {
                Console.WriteLine($"{student.GetNameTagText()}");
            }

            Console.WriteLine(Student.ShowAllWithAge());
            Console.WriteLine($"Gemiddelde leeftijd van de studenten is {Student.CalculateAverageAge()}");

            foreach (var lector in Lecturer.List)
            {
                Console.WriteLine(lector.ShowTaughtCourses());
            }
            foreach (var student in Student.List)
            {

                Console.WriteLine($"{student.ShowOne()}. Totale werklast: {student.CalculateWorkload()}");
            }
        }
        static void GuestLecturerToConsole()
        {
            //Jeff, Leff, , Modern Ways, 1000, 12/01/1956, 1, 1, 0489000010
            //3.Jason, Bauer, Cheap Things, 7, 03 / 04 / 1968, 1, 1, 0489000011
            GuestLecturer jeffL = new GuestLecturer("Jeff", "Leff", "Modern Ways", 1000, new DateTime(1956, 01, 12), 1, 1, "0489000010");
            GuestLecturer jasonB = new GuestLecturer("Jason", "Bauer", "Cheap Things", 7, new DateTime(1956, 04, 03), 1, 1, "0489000010");
            Lecturer.List = new List<Lecturer>
            {
                jeffL,
                jasonB
            };
            Console.WriteLine(GuestLecturer.ShowAll(6));
        }
        static void GuestLecturerToCsv()
        {
            GuestLecturer jeffL = new GuestLecturer("Jeff", "Leff", "Modern Ways", 1000, new DateTime(1956, 01, 12), 1, 1, "0489000010");
            GuestLecturer jasonB = new GuestLecturer("Jason", "Bauer", "Cheap Things", 7, new DateTime(1956, 04, 03), 1, 1, "0489000010");
            Lecturer.List = new List<Lecturer>
            {
                jeffL,
                jasonB
            };
            
            Console.WriteLine(jeffL.SaveToCsv());
            

        }
        static void GuestLecturerFromCsv()
        {
            GuestLecturer.ReadFromCsv();
        }
        static void Main(string[] args)
        {
            int userInput = 0;
            bool isRunning = true;
            do
            {
                Console.WriteLine("Welkom bij Schoolbeheer Examen!");
                Console.WriteLine(" Maak een keuze uit de volgende lijst:");
                Console.WriteLine("************************************************************");
                Console.WriteLine("1. Opgave 3: bestaande klassen gebruiken");
                Console.WriteLine("2. Opgave 4: Toon alle gastlectoren in de console");
                Console.WriteLine("3. Opgave 4: Alle gastlectoren opslaan in CSV bestand");
                Console.WriteLine("4. Opgave 4: Alle gastlectoren uitlezen uit Csv bestand en tonen in de console");
                Console.WriteLine("0. Stoppen ");
                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 0:
                        //Het menu blijft actief totdat de gebruiker op 0 klikt
                        isRunning = false;
                        break;
                    case 1:
                        UseSchoolAdminClasses();
                        //Als de gebruiker 1 intypt wordt de methode UseSchoolAdminClasses uitgevoerd
                        break;
                    case 2:
                        GuestLecturerToConsole();
                        //Als de gebruiker 2 intypt wordt de methode GuestLecturerToConsole uitgevoerd
                        break;
                    case 3:
                        GuestLecturerToCsv();
                        //Als de gebruiker 3 intypt wordt de methode GuestLecturerToCSV uitgevoerd.
                        break;
                    case 4:
                        GuestLecturerFromCsv();
                        //Als de gebruiker 4 intypt wordt de methode GuestLecturerFromCSV uitgevoerd
                        break;
                    default:
                        break;
                }

            } while (isRunning);
        }


    }
}
