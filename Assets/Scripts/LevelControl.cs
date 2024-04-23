using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelControl : MonoBehaviour
{
    [Header("Parameters")]
    public string levelName;
    public int price;
    public int levelNumber;
    public bool isCollected;
    
    
    [Header("Properties")]
    [SerializeField] private Image levelClosed;
    [SerializeField] private Image blockImage;
    [SerializeField] private Sprite unBlock;
    [SerializeField] private Sprite levelOpen;

   


    public void ChangeSprites()
    {
        blockImage.sprite = unBlock;
        levelClosed.sprite = levelOpen;
        SaveData.Current.levelsIsOpened = isCollected;
        SerializationManager.Save(SaveData.Current);
        

    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene(levelNumber);

    }


    
}