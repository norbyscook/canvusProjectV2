using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CanvasProject
{
    public class StatesTemplate : MonoBehaviour
    {
        #region Declarations

        // variable to take in  the current state text
        [TextArea(10, 14)] [SerializeField] protected string stateStory;
        public string story
        {
            get { return stateStory; }
        }

        // varaible to take in  the repeating texts
        [SerializeField] protected RepeatingTextTemplate repeatingText;


        // variable to take in the next possible choices the player can make
        [SerializeField] protected StatesTemplate[] nextStates;

        // variable for storing location of state
        protected string lable = "";

        #endregion

        #region Functions

        // called in MainScript to help with Changing States
        public StatesTemplate ManageStates(StatesTemplate currentState)
        {
            // get user input
            // get player input
            if (Input.anyKeyDown) // if user press any key once
            {
                currentState = ChangeState(currentState);
            }
            return currentState;

        }

        // check for user input and manage state
        private StatesTemplate ChangeState(StatesTemplate currentState)
        {
            string input = Input.inputString;
            // if input is valid
            // convert to interger and change state
            if (InputValid(input, out int n))
            {
                // manage state
                currentState = nextStates[n - 1];
            }
            return currentState;
        }

        // check to see if input is valid
        private bool InputValid(string input, out int n)
        {
            n = 0;

            if (int.TryParse((input), out n) && n <= nextStates.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        // displays the text according to the state
        // can be overridden to change text displays
        virtual public string GetDisplayText(StatesTemplate currentState)
        {
            // variable to concatinate strings to be displayed
            string text = "";
            // add location text
            text += "Current Location: " + currentState.lable + "\n";

            text += LineBreak();

            // add repeating text if repeating text not null reference
            if (repeatingText != null && repeatingText.textOne != "")
            {
                text += repeatingText.textOne + "\n";
            }

            // add story text if there is any
            if (currentState.story != "")
            {
            text += currentState.story + "\n";
            }

            // add repeating text if repeating text not null reference
            if (repeatingText != null && repeatingText.textEnd != "")
            {
                text += repeatingText.textEnd + "\n";
            }

            text += LineBreak();

            // add next states only if next states is not empty
            if (nextStates.Length != 0)
            {
                // for each location the player gets to go to, add that option to the game text
                for (int i = 0; i < nextStates.Length; i++)
                {
                    // add next locations as options
                    text += "\npress " + (i + 1) + " to go to " + currentState.nextStates[i].lable;
                }
            }

            // return string be displayed
            return text;
        }




        protected string LineBreak()
        {
            string text = "";
            for(int i = 0; i < 100; i++)
            {
                text += "-";
            }
            return text + "\n";
        }
        #endregion

    }
}
