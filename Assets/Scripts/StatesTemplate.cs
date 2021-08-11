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

        #region Manage States
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
                return false;
        }
        #endregion

        #region Display Text

        // called in MainScript to help with text display
        // displays the text according to the state
        // can be overridden to change text displays
        virtual public string GetDisplayText(StatesTemplate currentState)
        {
            // variable to concatinate strings to be displayed
            string text = "";
            // add location text
            text += "Current Location: " + currentState.lable + "\n";

            text += LineBreak();

            // add repeating text 
            text += AddRepeatingTxt(0);

            // add story text if there is any
            if (currentState.story != "")
            {
                text += currentState.story + "\n";
            }

            // add repeating text 
            text += AddRepeatingTxt(1);

            text += LineBreak();

            text += AddNextStates();

            // return string be displayed
            return text;
        }

        // add next avaliable options to text
        private string AddNextStates()
        {
            string text = "";
            // add next states only if next states is not empty
            if (nextStates.Length != 0)
            {
                // for each location the player gets to go to, add that option to the game text
                for (int i = 0; i < nextStates.Length; i++)
                {
                    // add next locations as options
                    text += "\npress " + (i + 1) + " to go to " + nextStates[i].lable;
                }
            }
            return text;
        }

        // add repeating text of textVersion if there is any
        // for the txtIndex:
            // 0 will be the first, 1 will be the last.
            // n > 1 will be any text between the first and last.
        private string AddRepeatingTxt(int txtIndex)
        {
            // if this state has repeating text
            // and the index is within the bounds of the array
            if (repeatingText != null && txtIndex < repeatingText.text.Length)
            {
                // add repeating text to text
                return repeatingText.text[txtIndex] + "\n";
            }
            return "";
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
