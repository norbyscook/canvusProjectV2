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
        // 0 will be the first, 1 will be the last.
        // n > 1 will be any text between the first and last. 
        [TextArea(10, 14)] [SerializeField] protected string[] repeatingTxt;
        public string[] text
        { 
            get { return repeatingTxt; }
        }
    }
}
