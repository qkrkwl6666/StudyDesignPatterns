using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quack : IQuack
{
    void IQuack.Quack()
    {
        Debug.Log("²Ð²Ð");
    }
}
