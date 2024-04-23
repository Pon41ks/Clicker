using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public  class LevelAccessControl : MonoBehaviour
{

    public  LevelControl[] checkAccess = {  };



    public  void BuyLevel(int indexLevel)
    {
        if (checkAccess[indexLevel].isCollected == false)
        {
            if (SaveData.Current.coinsCount >= checkAccess[indexLevel].price)
            {
                checkAccess[indexLevel].ChangeSprites();
                checkAccess[indexLevel].isCollected = true;
                Balance.coins -= checkAccess[indexLevel].price;
            }
        }
        else if (checkAccess[indexLevel] == true)
        {
            SceneManager.LoadScene(indexLevel);
            
        }
            
    }

}