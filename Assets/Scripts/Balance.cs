using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public static class Balance 
{
    public static int coins;
    public static readonly UnityEvent takeCoin = new();


    public static void AddCoin()
    {
        coins++;
        takeCoin.Invoke();
    }
   
}
