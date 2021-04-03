using System;

namespace FinalProjectProofOfConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            //string Series_Choice;
            string User_Series;
            string User_Date;
            string User_Age;//for Lord of The Rings
            string Process_Repeat;
            bool Process_Switch = false;

            Console.WriteLine("Welcome to the final project");

            Console.WriteLine("Please select a series");

            User_Series = Console.ReadLine();

            while (Process_Switch == false)
            {
                if (User_Series.ToUpper() == "LORD OF THE RINGS")
                {
                    Console.WriteLine("Please select an age");
                    User_Age = Console.ReadLine();

                    if(User_Age.ToUpper()=="FIRST AGE")
                    {
                        Console.WriteLine("Please enter a date in the format: Year 1-587");
                        User_Date = Console.ReadLine();

                        LOTR LOTR1 = new LOTR(User_Date, User_Age, User_Series);

                        LOTR1.FirstAge_Method(User_Date, User_Age);

                        Console.WriteLine("Would you like to try again");

                        Process_Repeat = Console.ReadLine();

                        if (Process_Repeat.ToUpper() == "YES")
                        {
                            Process_Switch = false;
                        }
                        else if (Process_Repeat.ToUpper() == "NO")
                        {
                            Console.WriteLine("Now exiting");
                            Process_Switch = true;
                            break;
                        }
                    }
                    else if(User_Age.ToUpper()=="SECOND AGE")
                    {
                        Console.WriteLine("Please enter a date in the format: Year 1-3441 ");
                        User_Date = Console.ReadLine();

                        LOTR LOTR2 = new LOTR(User_Date, User_Age, User_Series);

                        LOTR2.SecondAge_Method(User_Date, User_Age);

                        Console.WriteLine("Would you like to try again");

                        Process_Repeat = Console.ReadLine();

                        if (Process_Repeat.ToUpper() == "YES")
                        {
                            Process_Switch = false;
                        }
                        else if (Process_Repeat.ToUpper() == "NO")
                        {
                            Console.WriteLine("Now exiting");
                            Process_Switch = true;
                            break;
                        }
                    }
                    else if(User_Age.ToUpper()=="THIRD AGE")
                    {
                        Console.WriteLine("Please enter a date in the following format: 2-3021");
                        User_Date = Console.ReadLine();
                        LOTR LOTR3 = new LOTR(User_Date, User_Age, User_Series);
                        LOTR3.ThirdAge_Method(User_Date, User_Age);

                        Console.WriteLine("Would you like to try again");

                        Process_Repeat = Console.ReadLine();

                        if (Process_Repeat.ToUpper() == "YES")
                        {
                            Process_Switch = false;
                        }
                        else if (Process_Repeat.ToUpper() == "NO")
                        {
                            Console.WriteLine("Now exiting");
                            Process_Switch = true;
                            break;
                        }
                    }

                    Console.WriteLine("Please select a series");

                    User_Series = Console.ReadLine();
                }
            }
        }
    }
}
