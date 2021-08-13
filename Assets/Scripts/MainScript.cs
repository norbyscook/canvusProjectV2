using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace CanvasProject
{
    public class MainScript : MonoBehaviour
    {
        // reference to text being displayed
        [SerializeField] TextMeshProUGUI bodyText;
        // reference to the starting state
        [SerializeField] StatesTemplate currentState;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            // update text
            bodyText.text = currentState.GetDisplayText();
            // change state
            currentState = currentState.ManageStates(currentState);
        }

    }

}

