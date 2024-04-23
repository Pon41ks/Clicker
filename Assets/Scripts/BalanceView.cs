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
        Balance.TakeCoin.AddListener(ChangeCoinCount);
        ChangeCoinCount();
    }
    private void ChangeCoinCount()
    {
        coinsText.text = SaveData.Current.coinsCount.ToString();
    }

    
}
