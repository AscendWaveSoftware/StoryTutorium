using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTutorium
{
    class Room2 : State
    {

        public Room2()
        {
            Name = "Room2";
        }

        public override State? CheckConditions()
        {
            {
                if (Program.locationRoom2)
                {
                    return null;
                }
                return new Room1();
            }
        }

        public override void OnEntry()
        {
            Program.locationRoom2 = true;
            Console.WriteLine("OnEntry of Room2 was triggered.");

        }

        public override void OnExit()
        {
            Program.locationRoom2 = false;
            Console.WriteLine("OnExit of Room2 was triggered.");
        }

        public override void Update()
        {
            Console.WriteLine("Update of Room2 was triggered.");
            Console.WriteLine("Leave Room2? Enter \"Yes\" or \"No\"");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "yes")
            {
                Program.locationRoom2 = false;
                Program.locationRoom1 = true;
            }
        }
    }
}
