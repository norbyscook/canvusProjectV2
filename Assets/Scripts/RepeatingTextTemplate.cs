using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CanvasProject
{
    // a class for scriptable objects that will store text that will be repeated.
    [CreateAssetMenu(menuName = "State Texts/Repeating Texts")]
    public class RepeatingTextTemplate : ScriptableObject
    {
        // to store repeating texts in the story so that we don't have to rewrite them
        [SerializeField] protected Dictionary<string, string> repeatingTxt = new Dictionary<string, string>()
        {
            ["0"] = ""
        };

    }
}
