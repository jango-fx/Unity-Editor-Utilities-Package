using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ƒx.UnityUtils.Editor;

public class SearchableEnumDemo : MonoBehaviour
{
    public KeyCode LameKeyCode;
    [SearchableEnum]
    public KeyCode AwesomeKeyCode;

}
