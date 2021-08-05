using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CanvasProject
{
    public class NonPlayStatesTemplate : StatesTemplate
    {
        public override string GetDisplayText(StatesTemplate currentState)
        {
            // return story text if state text is not null
            if (stateStory != null)
            {
                return currentState.story;
            }
            return "";
        }
    }
}
