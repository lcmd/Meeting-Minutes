using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Meeting_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string meetingMinutes = ("MinutesMMDDYY.txt");
            StreamWriter meeting = new StreamWriter(meetingMinutes);
            using (meeting)
            {
                meeting.WriteLine("Back of the Class Entertainment");
                meeting.WriteLine("545 Lloyd Road \r\nEuclid, OH 44132");
            }

           Console.WriteLine("     ----------------------------------");
                Console.WriteLine("*****Meeting Minutes Information System*****"); //five for the founders
                Console.WriteLine("     ----------------------------------");
                Swag(); //spacer method
            
                Console.WriteLine("1. Create Meeting");
                Console.WriteLine("2. View Team");
                Console.WriteLine("3. Exit");
                Swag();

                int menuChoice = int.Parse(Console.ReadLine());
                // int marketing = int.Parse(Console.ReadLine());
                //int marketing = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {

                    case 1:
                        Console.WriteLine("Create Meeting");
                        Swag();
                        Console.WriteLine("Team Member Recording Minutes: ");
                        string recorder = Console.ReadLine();
                        Swag();
                        Console.WriteLine("Team Member Leading Meeting: ");
                        string leader = Console.ReadLine();
                        Swag();
                        Console.WriteLine("Date of Meeting formated MMDDYY: ");
                        int date = int.Parse(Console.ReadLine());
                        Swag();
                        Console.WriteLine("Choose Meeting Type");
                        List<string> meetingType = new List<string>() { "1. Marketing", "2. Performer Roster", "3. Administration" };
                        foreach (string meetings in meetingType)
                        {
                            Console.WriteLine(meetings);
                        }

                        //switch (marketing)
                        //    {
                        //        case 1:
                        //            Console.WriteLine("Marketing");
                        //            Console.WriteLine("Enter meeting Topic: ");
                        //            string meetingTopic = Console.ReadLine();
                        //            Console.WriteLine("Enter Meeting Notes: ");
                        //            string meetingNotes = Console.ReadLine();
                        //            break;
                        //    }


                        break;

                    case 2:
                        Console.WriteLine("View Team");
                        break;

                    case 3:
                        Console.WriteLine("Exit");
                        Swag();
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("That was not a choice");
                        break;
                }


            
          

        }

        static void Swag()
        {
            Console.WriteLine();
        }
    }
}
