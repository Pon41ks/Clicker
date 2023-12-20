
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Click : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private int score;
    [SerializeField] private int maxValue = 30;

    public Slider slider;
    [SerializeField] private TextMeshProUGUI currentClicks;
   

    private void Start()
    {
        //bool isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
        //score = PlayerPrefs.GetInt("money");
        //totalMoney = PlayerPrefs.GetInt("totalMoney", totalMoney);

    }
    public void OnClick()
    {
        score++;
        slider.value = score;
        currentClicks.text = $"{score} / {maxValue}";

        //totalMoney++;
        //PlayerPrefs.SetInt("money", score);
        //PlayerPrefs.SetInt("totalMoney", totalMoney);
    }

   
 

}
