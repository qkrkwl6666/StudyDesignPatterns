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
        Debug.Log($"ĳ���� ID : {Id}");
        Debug.Log($"ĳ���� �̸� : {Name}");
        Debug.Log($"ĳ���� ���ݷ� : {Attack}");
        Debug.Log($"ĳ���� ���� : {Defence}");
        Debug.Log($"ĳ���� ���ǵ� : {Speed}");
    }
}
