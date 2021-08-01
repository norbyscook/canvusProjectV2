using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStatesTemplate : StatesTemplate
{
    public override string GetDisplayText(StatesTemplate currentState)
    {
        string text = "";
        // store current state text into variable
        text += currentState.text.story;
        return text;
    }
}
