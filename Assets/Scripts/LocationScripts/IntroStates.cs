using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// states for the story intro
[CreateAssetMenu(menuName = "GameLocations/IntroStates")]
public class IntroStates : StatesTemplate
{
    public IntroStates()
    {
        locationName = "next";
    }
    
}
