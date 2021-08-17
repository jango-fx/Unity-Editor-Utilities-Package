using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ƒx.UnityUtils.Editor;

public class ReadOnlyAttributeDemo : MonoBehaviour
{
    bool toggle0;
    [SerializeField] bool toggle1;
    [ReadOnly] public bool toggle2;
    public bool toggle3;

    void Reset()
    {
        toggle0 = true;
        toggle1 = toggle0;
        toggle2 = toggle1;
        toggle3 = toggle2;
    }

    void OnValidate()
    {
        toggle2 = toggle3;
    }
}
