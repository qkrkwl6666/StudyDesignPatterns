using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter : MonoBehaviour
{
    IQuack iQuack;

    Hunter()
    {
        iQuack = new Quack();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Quack();
        }
    }

    public void Quack()
    {
        iQuack.Quack();
    }
}
