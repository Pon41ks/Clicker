using UnityEngine;
using TMPro;

public class BalanceView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;

    private void Awake()
    { 
        Balance.TakeCoin.AddListener(RefreshCoinCount);
        RefreshCoinCount();
    }
    private void RefreshCoinCount()
    {
        coinsText.text = SaveData.Current.coinsCount.ToString();
    }
}