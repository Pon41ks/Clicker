using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class Manager : MonoBehaviour
{
    [SerializeField] private Animator gameAnimator;
    [SerializeField] private Button startButton;
    [SerializeField] private GameObject shopButton;
    
    void Start()
    {
        gameAnimator = GetComponent<Animator>();
        gameAnimator.SetTrigger("FirstAnim");
    }

    public void PlaySecondAnim()
    {
        gameAnimator.SetTrigger("SecondAnim");
        shopButton.SetActive(true);
    }

}
