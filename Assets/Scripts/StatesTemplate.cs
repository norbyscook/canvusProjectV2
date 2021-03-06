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
                // return new state
                return ChangeState(currentState);
            }
            // if not return current state
            return currentState;

        }

        // check for user input and manage state
        private StatesTemplate ChangeState(StatesTemplate currentState)
        {
            // for each next option for the game
            // -1 because array index goes from 0 -> n - 1
            for (int index = 0; index <= nextStates.Length - 1; index++)
            {
                // if player pushes the corresponding option
                if (Input.GetKeyDown(KeyCode.Alpha1 + index))
                {
                    // return new state
                    return nextStates[index];
                }
            }
            // if not return non changed current state
            return currentState;
        }
        #endregion

        #region Display Text

        // called in MainScript to help with text display
        // displays the text according to the state
        // can be overridden to change text displays
        virtual public string GetDisplayText()
        {
            // variable to concatinate strings to be displayed
            string text = "";
            // add location text
            text += "Current Location: " + lable + "\n";

            text += LineBreak();

            // add repeating text 
            text += AddRepeatingTxt(0);

            // add story text if there is any
            if (stateStory != "")
            {
                text += stateStory + "\n";
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
                for (int index = 0; index < nextStates.Length; index++)
                {
                    // add next locations as options
                    text += "\npress " + (index + 1) + " to --> " + nextStates[index].lable;
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
                // and the string at that index is not empty.
                if (repeatingText.text[txtIndex] != "")
                {
                    // add repeating text to text
                    return repeatingText.text[txtIndex] + "\n";
                }
                
            }
            return "";
        }

        protected string LineBreak()
        {
            string text = "";
            for (int i = 0; i < 4; i++)
            {
                text += "-";
            }
            return text + "\n";
        }
        #endregion

    }
}
