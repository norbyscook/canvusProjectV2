using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// base class for other classes holding different states for the game
abstract public class StatesTextTemplate : ScriptableObject
{
    // the text for each of the states
    [TextArea(10, 14)] [SerializeField] string stateStory;

    // property to retrieve text of the state
    public string story
    {
        get { return stateStory; }
    }

    /*
    Name of the in game location.
    Each location will have one name to help player choose next choices.
    Each location can have different scriptable objects,
    representing the different states of that location
    */
    protected string stateLable;

    public string lable
    {
        get { return stateLable; }
    }

}
