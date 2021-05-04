// ---------------------------------------------------------------------------- 
// Author: Ryan Hipple
// Date:   05/01/2018
// ----------------------------------------------------------------------------

using UnityEngine;
using ArtCom.EditorUtilities.SearchableEnum;

namespace RoboRyanTron.SearchableEnum
{
    /// <summary>
    /// A demo of the SearchableEnumPopup on a ScriptableObject.
    /// </summary>
    //[CreateAssetMenu]
    public class ExampleConfigFile : ScriptableObject
    {
        [Tooltip("This enum is fucking miserable.")]
        public KeyCode LameKeyCode;
        
        [Tooltip("The finest enum browsing experience one can have.")]
        [SearchableEnum]
        public KeyCode AwesomeKeyCode;
    }
}
