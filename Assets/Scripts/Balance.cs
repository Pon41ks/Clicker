using UnityEngine.Events;

public static class Balance
{
    public static readonly UnityEvent TakeCoin = new();
    public static void AddCoin()
    {
        SaveData.Current.coinsCount++;
        TakeCoin.Invoke();
    }
}
