using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Duck : MonoBehaviour
{
    protected IFly iFly;
    protected IQuack iQuack;

    public abstract void Fly();
    public abstract void Quack();

    public void SetDuckType(IFly iFly, IQuack iQuack)
    {
        this.iFly = iFly;
        this.iQuack = iQuack;
    }
}
