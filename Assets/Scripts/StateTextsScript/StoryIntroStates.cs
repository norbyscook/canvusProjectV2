using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// states for the story menus like intro, ending, and main menu 
[CreateAssetMenu(menuName = "GameLocations/IntroStates")]
public class StoryIntroStates : StatesTextTemplate
{
    public StoryIntroStates()
    {
        stateLable = "next";
    }
    
}
