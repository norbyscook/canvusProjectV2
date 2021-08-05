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
        [TextArea(6, 10)] [SerializeField] string repeatingTextOne;
        public string textOne
        {
            get { return repeatingTextOne; }
        }

        [TextArea(6, 10)] [SerializeField] string repeatingTextEnd;
        public string textEnd
        {
            get { return repeatingTextEnd; }
        }
    }
}
