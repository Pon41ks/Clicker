using UnityEngine;
using UnityEngine.SceneManagement;
public  class LevelAccessControl : MonoBehaviour
{
    [SerializeField] private  LevelControl[] checkAccess;

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