
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Click : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private int score;
    [SerializeField] private int maxValue = 30;

    
    [SerializeField] private TextMeshProUGUI currentClicks;
    public Slider slider;
    

    public void OnClick()
    {
        if(score != maxValue)
        {
            score++;
            slider.value = score;
            currentClicks.text = $"{score} / {maxValue}";
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }




}
