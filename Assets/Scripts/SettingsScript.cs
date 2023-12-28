using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SettingsScript : MonoBehaviour
{

    [SerializeField] private Animator settingsAnimator;
    [SerializeField] private UnityEngine.UI.Button settingsButton;
    [SerializeField] private GameObject settingsPanel;
    

    void Start()
    {
        settingsAnimator = GetComponent<Animator>();
    }

    public void OpenAndCloseSettings()
    {
        if (!settingsPanel.activeInHierarchy) 
        {
            settingsAnimator.SetTrigger("OpenSettings");
        }
        else
        {
            settingsAnimator.SetTrigger("CloseSettings");
        }
        
        
        
    }
    

}
