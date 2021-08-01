using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    // reference to text being displayed
    [SerializeField] Text bodyText;
    [SerializeField] protected StatesTemplate currentState;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // call state
        currentState.Run();
    }

}

