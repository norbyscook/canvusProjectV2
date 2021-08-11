using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CanvasProject
{
    public class NonPlayStates : StatesTemplate
    {
        public override string GetDisplayText()
        {
            // return story text if state text is not null
            if (stateStory != null)
            {
                return stateStory;
            }
            return "";
        }
    }
}
