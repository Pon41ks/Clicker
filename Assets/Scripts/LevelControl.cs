using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelControl : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private string levelName;
    [SerializeField] private int price;
    private int _levelNumber;
    public bool IsCollected { get; private set; }
    
    [Header("References")]
    [SerializeField] private Image levelClosed;
    [SerializeField] private Image blockImage;
    [SerializeField] private Sprite unBlock;
    [SerializeField] private Sprite levelOpen;


    
    public void Initialize(int indexLevel)
    {
        _levelNumber = indexLevel;
        if (SaveData.Current.levels[_levelNumber])
        {
            ChangeSprites();
        }
    }

    public void BuyLevel(int indexLevel)
    {
        if (SaveData.Current.coinsCount >= price)
        {
            SaveData.Current.coinsCount -= price;
            SaveData.Current.levels[indexLevel] = true;
            ChangeSprites();
            SerializationManager.Save(SaveData.Current);
        }
    }
    private void ChangeSprites()
    {
        IsCollected = true;
        blockImage.sprite = unBlock;
        levelClosed.sprite = levelOpen;
    }
   
    public void GoToNextLevel()
    {
        Debug.Log(_levelNumber);
        if (SaveData.Current.levels[_levelNumber + 1])
            SceneManager.LoadScene(_levelNumber + 1);
        //else
            //SceneManager.LoadScene(_levelNumber);
    }
}