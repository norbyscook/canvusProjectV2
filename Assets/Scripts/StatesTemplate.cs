using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesTemplate : MonoBehaviour
{
    #region Declarations

    // variable to take in  the current state text
    [SerializeField] protected StatesTextTemplate stateText;
    public StatesTextTemplate text
    {
        get { return stateText; }
    }

    // varaible to take in  the repeating texts
    [SerializeField] protected RepeatingTextTemplate repeatingText;
    public RepeatingTextTemplate repeatTxt
    {
        get { return repeatingText; }
    }

    // variable to take in the next possible choices the player can make
    [SerializeField] protected StatesTemplate[] nextStates;
    public StatesTemplate[] next
    {
        get { return nextStates; }
    }
    #endregion

    #region Functions

    // called in MainScript to help with Changing States
    public StatesTemplate ManageStates(StatesTemplate currentState)
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


    // displays the text according to the state
    // can be overridden to change text displays
    virtual public string GetDisplayText(StatesTemplate currentState)
    {
        // variable to concatinate strings to be displayed
        string text = "";

        // add location text if state text is not null reference
        if (stateText != null)
        {
            text += "Current Location: " + currentState.text.lable + "\n";
        }

        // add repeating text if repeating text not null reference
        if (repeatingText != null)
        {
            text += repeatingText.textOne + "\n";
        }

        // add story text only if state text is not null reference
        if (stateText != null)
        {
            text += currentState.text.story + "\n";
        }

        // add repeating text if repeating text not null reference
        if (repeatingText != null)
        {
            text += repeatingText.textEnd + "\n";
        }

        Debug.Log(nextStates.Length + "\n");
        // add next states only if next states and state text is not null
        if (nextStates.Length != 0 && stateText != null)
        {
            // for each location the player gets to go to, add that option to the game text
            for (int i = 0; i < nextStates.Length; i++)
            {
                text += "\npress " + (i + 1) + " to go to " + nextStates[i].text.lable;
            }
        }

        // return string be displayed
        return text;
    }
    #endregion

}
