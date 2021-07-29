using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesTemplate : MainScript
{
    // variable for the current state text
    [SerializeField] StatesTextTemplate stateText;
    public StatesTextTemplate text
    {
        get { return stateText; }
    }

    // variable for the next possible choices the player can make
    [SerializeField] StatesTemplate[] nextStates;
    public StatesTemplate[] next
    {
        get { return nextStates; }
    }

    virtual protected string GetDisplayText()
    {
        // store current state text into variable
        string text = "";


        // for each location the player gets to go to, add that option to the game text
        for (int i = 0; i < nextStates.Length; i++)
        {
            text += "\npress " + (i + 1) + " to go to " + nextStates[i].text.location;
        }

        return text;
    }

    protected void ManageState(StatesTextTemplate[] nextState)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
        }
    }


}
