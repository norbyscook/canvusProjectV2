using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    // reference to text being displayed
    [SerializeField] public Text bodyText;
    // reference to the starting state
    [SerializeField] public StatesTemplate currentState;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // update text
        bodyText.text = currentState.GetDisplayText(currentState);
        // change state
        currentState = currentState.ChangeStates(currentState);



    }

}

