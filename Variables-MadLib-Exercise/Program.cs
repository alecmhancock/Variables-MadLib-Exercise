using System;

namespace Variables_MadLib_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string adjective;
            string adjective2;
            string typeOfBird;
            string roomInAHouse;
            string pastTenseVerb;
            string verb;
            string relativesName;
            string noun;
            string typeOfLiquid;
            string verbEndingInING;
            string pluralPartOfTheBody;
            string pluralNoun;
            string secondVerbEndingInING;
            string noun2;

            // Give vaules to the variables above by taking input from the user. Example-- string variable name = Console.ReadLine();
            // Be sure to prompt the user before each value is assigned. Example -- Console.WriteLine("Please give me an adjective.");
            Console.Write("Please enter an adjective:");
            adjective = Console.ReadLine();

            Console.Write("Please enter another adjective:");
            adjective2 = Console.ReadLine();

            Console.Write("Please enter a type of bird:");
            typeOfBird = Console.ReadLine();

            Console.Write("Please enter a room in your house:");
            roomInAHouse = Console.ReadLine();

            Console.Write("Please enter a past tense verb:");
            pastTenseVerb = Console.ReadLine();

            Console.Write("Please enter a present tense verb:");
            verb = Console.ReadLine();

            Console.Write("Please enter a relative's name:");
            relativesName = Console.ReadLine();

            Console.Write("Please enter a noun:");
            noun = Console.ReadLine();

            Console.Write("Please enter a type of liquid:");
            typeOfLiquid = Console.ReadLine();

            Console.Write("Please enter a verb ending in 'ing':");
            verbEndingInING = Console.ReadLine();

            Console.Write("Please enter a plural part of the body:");
            pluralPartOfTheBody = Console.ReadLine();

            Console.Write("Please enter a plural noun:");
            pluralNoun = Console.ReadLine();

            Console.Write("Please enter another verb ending in 'ing':");
            secondVerbEndingInING = Console.ReadLine();

            Console.Write("Please enter a noun:");
            noun2 = Console.ReadLine();

            // MadLib
            Console.WriteLine($"It was a {adjective}, cold November day, I woke up to the {adjective2} smell of {typeOfBird} roasting in the {roomInAHouse} downstairs.\nI {pastTenseVerb} down the stairs to see if I could help {verb} the dinner.\nMy mom said, 'See if {relativesName} needs a fresh {noun}.'\nSo I carried a tray of glasses full of {typeOfLiquid} into the {verbEndingInING} room.\nWhen I got there I couldn't believe my {pluralPartOfTheBody}! There were {pluralNoun} {secondVerbEndingInING} on the {noun2}!");
            
            // Run the application and see the story you've created


        }
    }
}
