using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    // reference to text being displayed
    [SerializeField] Text bodyText;
    [SerializeField] StatesTemplate currentState;
    
    // Start is called before the first frame update
    void Start()
    {
        // set first state
    }

    // Update is called once per frame
    void Update()
    {
        // manage states
        // display text
    }

    // displays game text along with next options
    string GetDisplayText(StatesTemplate[] nextStates)
    {
        // store current state text into variable
        string text = currentState.story;

        // for each location the player gets to go to, add that option to the game text
        for (int i = 0; i < nextStates.Length; i++)
        {
            text += "\npress " + (i + 1) + " to go to " + nextStates[i].location;
        }
        return text;
    }

    // switch to next states based on user input
    void ManageState(StatesTemplate[] nextState)
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

