using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    public string Id { get; }
    public string Name { get; }
    public int Attack { get; }
    public int Defence { get; }
    public float Speed { get; }

    public string CurrentEquipment();
}
