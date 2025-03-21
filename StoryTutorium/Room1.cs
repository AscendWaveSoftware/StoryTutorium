using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTutorium
{
    class Room1 : State
    {
        private static bool roomChangeTracker1;

        public Room1()
        {
            Name = "Room1";
        }


        public override State? CheckConditions()
        {
            if (Program.locationRoom1)
            {
                return null;
            }
            return new Room2();
        }

        public override void OnEntry()
        {
            Program.locationRoom1 = true;
            Console.WriteLine("OnEntry of Room1 was triggered.");
        }

        public override void OnExit()
        {
            Program.locationRoom1 = false;
            Console.WriteLine("OnExit of Room1 was triggered.");

        }

        public override void Update()
        {
            Console.WriteLine("Update of Room1 was triggered.");
            Console.WriteLine("Leave Room1? Enter \"Yes\" or \"No\"");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
            Program.locationRoom1 = false;
            Program.locationRoom2 = true;
            }
        }
    }
}
