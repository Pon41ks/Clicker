
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private int score;
    [SerializeField] private int maxValue;
    [SerializeField] private int currentLevel;
    
 
    [Header("Properties")]
    [SerializeField] private GameObject gameCanvas;    
    [SerializeField] private TextMeshProUGUI currentClicks;
    [SerializeField] private Image mask;

    public static readonly UnityEvent<int> AddScore = new();
    
    private void GetcurrentFill()
    {
        float fillAmount = (float)score / (float)maxValue;
        mask.fillAmount = fillAmount;
    }
    private void Update()
    {
        
    }

    public void OnClick()
    {
        if (score != maxValue)
        { 
            AddScore.Invoke(score);
            Balance.AddCoin();
            Debug.Log(Balance.coins);
            score++;
            currentClicks.text = $"{score} / {maxValue}";
            GetcurrentFill();
        }     
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(currentLevel + 1);
    }




}
