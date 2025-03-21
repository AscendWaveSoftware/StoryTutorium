using StoryTutorium;

namespace StoryTutorium
{
    internal class Program
    {
        public static bool locationRoom1;
        public static bool locationRoom2;
        public static bool gameRunning = true;
        public static StateMachine gameManager = new();

        static void Main(string[] args)
        {
            locationRoom1 = true;
            while (gameRunning)
            {
                gameManager.Update();
            }
        }


    }
}