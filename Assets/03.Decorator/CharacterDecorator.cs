using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterDecorator : ICharacter
{
    protected ICharacter character;

    public virtual string Id => character.Id;
    public virtual string Name => character.Name;
    public virtual int Attack => character.Attack;
    public virtual int Defence => character.Defence;
    public virtual float Speed => character.Speed;

    public string CurrentEquipment()
    {
        return Id;
    }
}
