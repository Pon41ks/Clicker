using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OpenAndCloseShop : MonoBehaviour
{
    [SerializeField] private GameObject shopCanvas;
    [SerializeField] private GameObject openShopButton;
    [SerializeField] private GameObject VictoryPanel;
    
    public void OpenShop()
    {
        shopCanvas.SetActive(true);
        openShopButton.SetActive(false);
        VictoryPanel.SetActive(false);

    }
    
    public void CloseShop()
    {
        openShopButton.SetActive(true);
        shopCanvas.SetActive(false);
        VictoryPanel.SetActive(true);
    }
    
}
