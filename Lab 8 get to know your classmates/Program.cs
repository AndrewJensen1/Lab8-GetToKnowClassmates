using System;

namespace Lab_8_get_to_know_your_classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsArray = { "Bill", "Mike", "Meagan", "Dave", "Lisa" };
            string[] hometownArray = { "Detroit", "White Lake", "Waterford", "Commerce", "Clarkston" };
            string[] foodArray = { "Pizza", "Hotdogs", "Nachos", "Tacos", "Mac & Cheese" };
            Console.WriteLine("Welcome to the 2019 C# class, please select a student to know more about.");

            do
            {
                try
                {
                    DisplayPeoples(studentsArray);
                    int input = UserInput();
                    //DisplayInfo(input, studentsArray, hometownArray, foodArray);
                    Console.WriteLine($"Great! You Selected {studentsArray[input -1]}");
                    Console.WriteLine($"What would you like to know more about {studentsArray[input-1]} (hometown? or food?)");
                    string input1 = Console.ReadLine().ToLower();

                    if (input1 == "hometown" || input1 == "home town")
                    {
                        Console.WriteLine($"{studentsArray[input-1]} lives in { hometownArray[input - 1]}\n");
                    }
                    else if (input1 == "food" || input1 == "favorite food")
                    {
                        Console.WriteLine($"{studentsArray[input-1]} likes {foodArray[input -1]}\n");
                    }
                    else
                    {

                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect option please select again");
                }
            }
            while (Continue());
        }
        public static void DisplayPeoples(string[] studentArray)
        {
            for (int i = 0; i < studentArray.Length; i++)
            {
                Console.WriteLine($"{i+1}: {studentArray[i]}");
            }
        }
        public static int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }
        
        //public static void DisplayInfo(int input, string[] studentsArray, string[] hometownArray, string[] foodArray)
        //{
        //    Console.WriteLine(studentsArray[input-1]);
        //    Console.WriteLine(hometownArray[input-1]);
        //    Console.WriteLine(foodArray[input-1]);
        //}

        public static bool Continue()
        {
            Console.WriteLine($"Press {'y'} to continue or any other key to exit. . .");

            char response = Console.ReadKey(true).KeyChar;

            if (response == 'y')
            {
                return true;
            }
            else if (response != 'y')
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}
