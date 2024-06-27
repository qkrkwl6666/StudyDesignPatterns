using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, ICharacter
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = "Default";
    public int Attack { get; set; } = 0;
    public int Defence { get; set; } = 0;
    public float Speed { get; set; } = 5f;

    public string CurrentEquipment()
    {
        return Id;
    }

    public void DisPlayStats()
    {
        Debug.Log($"캐릭터 ID : {Id}");
        Debug.Log($"캐릭터 이름 : {Name}");
        Debug.Log($"캐릭터 공격력 : {Attack}");
        Debug.Log($"캐릭터 방어력 : {Defence}");
        Debug.Log($"캐릭터 스피드 : {Speed}");
    }
}
