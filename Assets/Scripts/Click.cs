
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

    [Header("Properties")]
    [SerializeField] private GameObject gameCanvas;
    [SerializeField] private Image imageObj;
    [SerializeField] private Sprite result;
    [SerializeField] private TextMeshProUGUI currentClicks;
    [SerializeField] private Slider slider;

    public static readonly UnityEvent<int> AddScore = new();
   


    public void OnClick()
    {
        if (score != maxValue)
        {
            AddScore.Invoke(score);
            Balance.AddCoin();
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
