using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    // reference to text being displayed
    [SerializeField] Text bodyText;
    [SerializeField] StatesTemplate currentState;
    private string test = "hi";
    
    // Start is called before the first frame update
    void Start()
    {
        bodyText.text = DisplayText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string DisplayText()
    {
        string text = currentState.getText + "\npress 1 to go to: " + currentState.getLocationName;
        return text;
    }


}

