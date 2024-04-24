using UnityEngine;
using UnityEngine.SceneManagement;
public  class LevelAccessControl : MonoBehaviour
{
    [SerializeField] private  LevelControl[] checkAccess;

    private void Start()
    {
        for (var i = 0; i < checkAccess.Length; i++)
        {
            Debug.Log(SaveData.Current.levels[i]);
            if (checkAccess.Length != SaveData.Current.levels.Length)
            {
                SaveData.Current.levels = new bool[checkAccess.Length];
                SaveData.Current.levels[0] = true;
            }
            var level = checkAccess[i];
            level.Initialize(i);
        }
    }

    public void SelectLevel(int indexLevel)
    {
        if (checkAccess[indexLevel].IsCollected == false)
        {
            checkAccess[indexLevel].BuyLevel(indexLevel);
        }
        else if (checkAccess[indexLevel] == true)
        {
            SceneManager.LoadScene(indexLevel);
        }

    }


}