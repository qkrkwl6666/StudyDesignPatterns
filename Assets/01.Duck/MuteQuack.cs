using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteQuack : IQuack
{
    public void Quack()
    {
        Debug.Log("소리가 없는 오리임");
    }
}
