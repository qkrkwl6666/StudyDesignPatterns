using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPlayerHp : MonoBehaviour, IObserver
{
    private PlayerInfo playerInfo;
    public TextMeshProUGUI hpText;

    private void Awake()
    {
        playerInfo = GameObject.FindWithTag("Player").GetComponent<PlayerInfo>();
        playerInfo.JoinOberver(this);
        hpText.text = $"Player HP : {playerInfo.Hp}";
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.F1))
        {
            Debug.Log("Àú´Â Å»ÅðÇÏ°Ú½À´Ï´Ù");
            playerInfo.ExitOberver(this);
        }
    }

    public void ObserverUpdate()
    {
        hpText.text = $"Player HP : {playerInfo.Hp}";
    }
}
