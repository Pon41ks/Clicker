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
    
    
}
