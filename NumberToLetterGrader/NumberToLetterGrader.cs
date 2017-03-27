using System;

///-----------------------------------------------------------------
///   Namespace:    GradeCalculator
///   Description:  Input a number grade to get its letter equivalent
///   Author:       Derek Wolters                
///   Date:         3.27.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------

namespace NumberToLetterGrader
{
    class NumberToLetterGrader
    {
        static void Main(string[] args)
        {
            //initialize variables
            int numGrade = 0;            
            string result = "";
            bool keepGoing = true;

            Console.WriteLine("This program will convert a number grade to a letter");

            while (keepGoing)
            {                         
                //get user input
                numGrade = getInput();

                //calculate grade
                result = calcGrade(numGrade);
                displayResult(result);

                //exit program               
                if (exitProgram()) break;
            }
        }

        static int getInput()
        {
            string input = "";
            int temp;

            Console.WriteLine("Enter a number grade:");

            input = Console.ReadLine();

            while (!int.TryParse(input, out temp))
            {
                Console.WriteLine("Not a valid input. Try again.");
                input = Console.ReadLine();
            }

            return temp;
        }


        //this can probably be done more efficiently, but I've not found that solution yet.
        static String calcGrade(int numGrade)
        {
            string result = "";
      
            if (numGrade >= 99)
            {
                result = "A+";
            }
            else if (numGrade <= 98 && numGrade >= 90)
            {
                result = "A";
            }
            else if (numGrade == 89 || numGrade == 88)
            {
                result = "A-";
            }
            else if (numGrade == 87 || numGrade == 86)
            {
                result = "B+";
            }
            else if (numGrade >= 82 && numGrade <= 85)
            {
                result = "B";
            }
            else if (numGrade == 81 || numGrade == 80)
            {
                result = "B-";
            }
            else if (numGrade == 79 || numGrade == 78)
            {
                result = "C+";
            }
            else if (numGrade >= 69 && numGrade <= 77)
            {
                result = "C";
            }
            else if (numGrade == 68 || numGrade == 67)
            {
                result = "C-";
            }
            else if (numGrade == 66 || numGrade == 65)
            {
                result = "D+";
            }
            else if (numGrade >= 62 && numGrade <= 64)
            {
                result = "D";
            }
            else if (numGrade == 61 && numGrade == 60)
            {
                result = "D-";
            }
            else if (numGrade <= 59)
            {
                result = "F";
            }

            return result;
        }

        static void displayResult(string grade)
        {
            Console.WriteLine("The grade is " + grade + ".");
        }

        static Boolean exitProgram()
        {
            string xitChoice = "";

            Console.WriteLine("Do you want to continue? Enter Y or N.");

            xitChoice = Console.ReadLine().ToUpper();

            while (xitChoice != "N" && xitChoice != "Y")
            {
                Console.WriteLine("Not a vaid answer. Do you want to continue? Enter Y or N.");
                xitChoice = Console.ReadLine().ToUpper();
            }

            return xitChoice == "N" ? true : false;
        }
    }
}
