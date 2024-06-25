using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFly : IFly
{
    public void Fly()
    {
        Debug.Log("저는 못나는 오리인데요");
    }
}
