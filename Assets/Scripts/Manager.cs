using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class Manager : MonoBehaviour
{
    [Header("parameters")]
    [SerializeField] private  int maxValueScore;
    

    [Header("Properties")]
    [SerializeField] private Animator gameAnimator;
    [SerializeField] private Image imageObj;
    [SerializeField] private Sprite result;
    [SerializeField] private GameObject clickButton;

    private void Awake()
    {
        Click.AddScore.AddListener(ChangeImageAndShowVictoryPanel);

    }
    void Start()
    {
        gameAnimator = GetComponent<Animator>();
        gameAnimator.SetTrigger("FirstAnim");
        Balance.coins = PlayerPrefs.GetInt("Coin");

    }

    public void PlaySecondAnim()
    {
        gameAnimator.SetTrigger("SecondAnim");

    }
    public void ChangeImageAndShowVictoryPanel(int score)
    {
        if(score == maxValueScore)
        {
            gameAnimator.SetTrigger("ChangeImage");
            gameAnimator.SetTrigger("Victory");
            clickButton.SetActive(false);
        }
       
       
    }

    

    
    public void ChangeSprite()
    {
        imageObj.sprite = result;
    }

}
