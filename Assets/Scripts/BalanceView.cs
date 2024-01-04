using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System.Runtime.CompilerServices;

public class BalanceView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;
    

    private void Awake()
    { 
        Balance.takeCoin.AddListener(ChangeCoinCount);
        ChangeCoinCount();
    }
    private void ChangeCoinCount()
    {
        coinsText.text = Balance.coins.ToString();
    }

    
}
