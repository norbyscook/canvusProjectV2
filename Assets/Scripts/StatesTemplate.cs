using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// base class for other classes holding different states for the game
abstract public class StatesTemplate : ScriptableObject
{
    // the text for each of the states
    [TextArea(10, 14)][SerializeField] string stateText;

    // next possible states player can go to
    [SerializeField] StatesTemplate[] nextStates;

    /*
    Name of the in game location.
    Each location will have one name to help player choose next choices.
    Each location can have different scriptable objects,
    representing the different states of that location
    */
    protected string locationName;

    public string getLocationName
    {
        get { return locationName; }
    }

    // property to retrieve text of the state
    public string getText
    {
        get { return stateText; }
    }

    // property to retrieve next possible states
    public StatesTemplate[] getNextStates
    {
        get { return nextStates; }
    }
}
