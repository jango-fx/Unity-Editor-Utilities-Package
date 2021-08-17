using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ƒx.UnityUtils.Editor;

public class ReorderableListDemo : MonoBehaviour
{

    public List<string> stringListRigid = new List<string>();
    [Space(20)]
    [Reorderable] public List<string> stringListReorderable = new List<string>();
    public string theString = "";
    [Space(20)]
    [Reorderable] public string[] stringArrayReorderable = new string[3];


    void Reset()
    {
        stringListRigid.Add("a");
        stringListRigid.Add("b");
        stringListRigid.Add("c");

        stringListReorderable.Add("a");
        stringListReorderable.Add("b");
        stringListReorderable.Add("c");
    }

    void OnValidate()
    {
        theString = "";
        foreach (string s in stringListReorderable)
            theString += s;
    }

}
