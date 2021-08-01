using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesTemplate : MonoBehaviour
{
    #region Declarations

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
    #endregion

    #region Functions

    // called in MainScript to help with Changing States
    public StatesTemplate ChangeStates(StatesTemplate currentState)
    {

        return ManageState(nextStates, currentState);
    }

    // displays the text according to the state
    // can be overridden to change text displays
    virtual public string GetDisplayText(StatesTemplate currentState)
    {
        
        string text = "";
        // stores current state lable into text
        text += "Current Location: " + currentState.text.lable + "\n";
        // store current state text into variable
        text += currentState.text.story;
        // for each location the player gets to go to, add that option to the game text
        for (int i = 0; i < nextStates.Length; i++)
        {
            text += "\npress " + (i + 1) + " to go to " + nextStates[i].text.lable;
        }

        return text;
    }

    // Change state based on user input
    protected StatesTemplate ManageState(StatesTemplate[] nextStates, StatesTemplate currentState)
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            currentState = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            currentState = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            currentState = nextStates[2];
        }
        return currentState;
    }
    #endregion

}
