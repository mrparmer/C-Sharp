using System;

namespace School_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Asterix());
            Console.WriteLine(SchoolInformation());
            Console.WriteLine(Asterix());
        }

        static string Asterix()
        {
            return "**************************************************";
        }

        static string SchoolInformation ()
        {
            string schoolName = "Kennesaw State University";
            string schoolCountry = "USA";
            int schoolCost = 15000;
            int numOfStudents = 2000;

            string schoolInfo = String.Format("School Name:         {0}\n" + 
                                              "School Country:      {1}\n" + 
                                              "School Cost:         {2:C2}\n" + 
                                              "Student Population:  {3}", 
                                              schoolName, schoolCountry, schoolCost, numOfStudents);

            return schoolInfo;
        }
    }
}
