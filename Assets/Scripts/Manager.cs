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
    [SerializeField] private Button startButton;
    [SerializeField] private GameObject shopButton;
    [SerializeField] private Image imageObj;
    [SerializeField] private Sprite result;

    private void Awake()
    {
        Click.AddScore.AddListener(ChangeImage);

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
    public void ChangeImage(int score)
    {
        if(score == maxValueScore)
        {
            gameAnimator.SetTrigger("ChangeImage");
        }
       
       
    }
    public void ChangeSprite()
    {
        imageObj.sprite = result;
    }

}
