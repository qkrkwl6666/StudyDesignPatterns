using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    public void JoinOberver(IObserver observer);
    public void ExitOberver(IObserver observer);
}
