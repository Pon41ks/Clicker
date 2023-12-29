using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private string levelName;
    [SerializeField] private int price;
    [SerializeField] private int access = 0;
    [SerializeField] private int levelNumber;

    [Header("Properties")]
    [SerializeField] private Image levelClosed;
    [SerializeField] private Image blockImage;
    [SerializeField] private Sprite unBlock;
    [SerializeField] private Sprite levelOpen;

    

    public void Awake()
    {
        AccessUpdate();
    }
    private void AccessUpdate()
    {
        access = PlayerPrefs.GetInt(levelName + "Access" );
       
        if (access == 1)
        {
            blockImage.sprite = unBlock;
            levelClosed.sprite = levelOpen;
        }
    }

    public void BuyLevel()
    {
        if (access == 0)
        {
            if (Balance.coins >= price)
            {
                PlayerPrefs.SetInt(levelName + "Access", 1);              
                PlayerPrefs.SetInt("Coin", Balance.coins - price);
                
                AccessUpdate();
            }
        }
        else
        {
            SceneManager.LoadScene(levelNumber);
        }
    }
}
