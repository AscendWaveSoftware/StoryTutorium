namespace StoryTutorium
{
    public abstract class State
    {
        public string Name;

        public State()
        {
            Name = "";
        }


        public abstract State? CheckConditions();
        public abstract void Update();
        public abstract void OnEntry();
        public abstract void OnExit();



    }
}