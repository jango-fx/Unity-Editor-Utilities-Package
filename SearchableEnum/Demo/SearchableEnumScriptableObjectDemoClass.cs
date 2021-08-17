// ---------------------------------------------------------------------------- 
// Author: Ryan Hipple
// Date:   05/01/2018
// ----------------------------------------------------------------------------

using UnityEngine;
using ƒx.UnityUtils.Editor;

[CreateAssetMenu(menuName = "Scriptable Objects/SearchableEnumDemo")]
public class SearchableEnumScriptableObjectDemoClass : ScriptableObject
{
    [Tooltip("This enum is fucking miserable.")]
    public KeyCode LameKeyCode;

    [Tooltip("The finest enum browsing experience one can have.")]
    [SearchableEnum]
    public KeyCode AwesomeKeyCode;
}