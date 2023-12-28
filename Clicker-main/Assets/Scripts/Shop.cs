using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private Animator shopAnimator;
    [SerializeField] private GameObject openShopButton;
    private void Start()
    {
        shopAnimator = GetComponent<Animator>();
    }
    public void OpenShop()
    {
        openShopButton.SetActive(false);
        shopAnimator.SetTrigger("OpenShop");
    }

    public void CloseShop()
    {
        openShopButton.SetActive(true);
        shopAnimator.SetTrigger("ShopClose");
    }
}
