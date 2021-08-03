using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonPlayStatesTemplate : StatesTemplate
{
    public override string GetDisplayText(StatesTemplate currentState)
    {
        // return story text if state text is not null
        if(stateText != null)
        {
            return currentState.text.story;
        }
        return "";
    }
}
