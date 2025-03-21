using StoryTutorium;

namespace StoryTutorium
{
    internal class Program
    {
        public static bool locationRoom1;
        public static bool locationRoom2;
        public static bool gameRunning = true;
        public static StateMachine gameManager = new();
        public static Player player = new();


        static void Main(string[] args)
        {
            locationRoom1 = true;
            while (gameRunning)
            {
                player.Drehen(); // um drehen zu testen. Muss woanders untergebracht werden.
                player.Inventar(); // um Inventar zu testen. Muss woanders untergebracht werden.
                gameManager.Update();
            }
        }


    }
}