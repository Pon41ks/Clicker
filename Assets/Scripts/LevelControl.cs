using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelControl : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private string levelName;
    [SerializeField] private int price;
    [SerializeField] private int levelNumber;
    public bool IsCollected { get; private set; }
    
    [Header("References")]
    [SerializeField] private Image levelClosed;
    [SerializeField] private Image blockImage;
    [SerializeField] private Sprite unBlock;
    [SerializeField] private Sprite levelOpen;
    
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
        SceneManager.LoadScene(levelNumber);
    }
}