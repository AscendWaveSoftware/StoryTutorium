using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTutorium
{
    class StateMachine
    {
        public State activeState;
        public State? nextState;

        public StateMachine()
        {
            activeState = new Room1();
            nextState = null;
        }

        public void Update()
        {
            if (activeState.CheckConditions() != null)
            {
                nextState = activeState.CheckConditions();
                activeState.OnExit();
                if (nextState != null)
                {
                nextState.OnEntry();
                activeState = nextState;
                }
            }
            activeState.Update();
        }
    }
}
