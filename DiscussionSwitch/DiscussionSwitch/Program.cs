/*
 * Author: CJ BUSCA
 * Class: IT230
 * Assignment: Discussion 4
 */

using System;

namespace DiscussionSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Athestetically-pleasing User Interface

            Console.WriteLine("Welcome to SNHU's Automated Course Application!\n");
            Console.WriteLine("***********************************************");
            Console.WriteLine("List of Classes:                              *\n 1 - Foundations in Application Development   *\n 2 - Fundamentals of Information Technology   *\n 3 - Computer Platform Technologies           *\n 4 - Website Design                           *\n 5 - Object Orientation Analysis and Design   *\n 6 - IT Project Management                    *\n 7 - Database Design and Management           *");
            Console.WriteLine("***********************************************");

            do //do-while statement declaration
            {
                Console.WriteLine("\nChoose your class: ");

                int courseInput = Console.ReadKey().KeyChar; //Declare course input as Int casts type to Char
                string courseName; //Empty string utilized for storing input from the switch statement 

                switch (courseInput) //Switch statement initialization the cases scan for input specified
                    //If the scanned Char is selected then the string specified will be stored within the empty container "courseName"
                {
                    case '1':
                        courseName = "IT 145";
                        break;

                    case '2':
                        courseName = "IT 200";
                        break;

                    case '3':
                        courseName = "IT 201";
                        break;

                    case '4':
                        courseName = "IT 270";
                        break;

                    case '5':
                        courseName = "IT 315";
                        break;

                    case '6':
                        courseName = "IT 328";
                        break;

                    case '7':
                        courseName = "IT 330";
                        break;

                    default:
                        courseName = "Undefined";
                        break;
                }

                //More UI stuff. 

                Console.Write("\nYou have successfully chosen course: " + courseName + "\n");
                Console.WriteLine("Would you like to take an additional class? Y/N");
            }

            while ((Console.ReadLine().ToUpper() == "Y"));



        }
    }
}
