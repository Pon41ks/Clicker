using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
   public void GoToNextLevel(int indexLevel)
    {
        Debug.Log(indexLevel);
        if(indexLevel < 5)
        {
            if (SaveData.Current.levels[indexLevel + 1])
            {
                SceneManager.LoadScene(indexLevel + 1);
            }
            else
            {
                SceneManager.LoadScene(indexLevel);
            }
        }
        SceneManager.LoadScene(indexLevel);
        
           
       

        
    }
}
