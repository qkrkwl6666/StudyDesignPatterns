using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MallardDuck : Duck
{
    MallardDuck()
    {
        iQuack = new Squeak();
        iFly = new FlywithWings();
    }

    public override void Fly()
    {
        iFly.Fly();
    }

    public override void Quack()
    {
        iQuack.Quack();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Fly();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Quack();
        }

        // 실시간으로 오리 변경
        if (Input.GetKeyDown(KeyCode.D))
        {
            SetDuckType(new NoFly(),new Quack());
        }
    }

}
