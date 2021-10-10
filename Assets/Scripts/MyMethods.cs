using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyMethods
{
    public static int GetWhatID(Transform tr) => int.Parse(tr.name.Split('_')[1]);
}
