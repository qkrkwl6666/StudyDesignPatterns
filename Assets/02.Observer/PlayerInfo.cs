using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour, ISubject
{
    public List<IObserver> observers = new List<IObserver>();

    public void JoinOberver(IObserver observer)
    {
        observers.Add(observer);
    }
    public void ExitOberver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public int Hp { get; private set; } = 1000;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.F2))
        {
            Attacked();
        }
    }

    public void Attacked()
    {
        Hp -= 100;

        foreach(IObserver observer in observers)
        {
            observer.ObserverUpdate();
        }
    }
}
