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
    [SerializeField] private GameObject shopCloseButton;
    [SerializeField] private GameObject victoryEffect;

    private void Awake()
    {
        Click.AddScore.AddListener(ChangeImageAndShowVictoryPanel);
        SaveData.Current = (SaveData)SerializationManager.Load();
                

    }
    private void Update()
    {
        Win();
    }
    private void Start()
    {
        gameAnimator = GetComponent<Animator>();
        gameAnimator.SetTrigger("FirstAnim");
        Debug.Log(SaveData.Current.coinsCount);
        SerializationManager.Save(SaveData.Current);


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
            shopCloseButton.SetActive(false);
            

        }
 
    }
   
    public void ChangeSprite()
    {
        imageObj.sprite = result;
    }

    private void Win()
    {
        if (victoryEffect.activeInHierarchy)
        {
            SerializationManager.Save(SaveData.Current);
            
        }
    }

}
