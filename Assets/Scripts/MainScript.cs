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
        bodyText.text = DisplayText(currentState.getNextStates);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string DisplayText(StatesTemplate[] nextStates)
    {
        // store current state text into variable
        string text = currentState.getText;

        // for each location the player gets to go to, add that option to the game text
        for (int i = 0; i < nextStates.Length; i++)
        {
            text += "\npress " + (i + 1) + " to go to " + nextStates[i].getLocationName;
        }
        return text;
    }


}

