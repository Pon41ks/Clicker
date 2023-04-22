using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchMenu : MonoBehaviour
{
    public int money;
    public int total_Money;
    [SerializeField] Button firstAch;
    [SerializeField] bool isFirst;

    private void Start()
    {
        money = PlayerPrefs.GetInt("money");
        total_Money = PlayerPrefs.GetInt("totalMoney");
        isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
        if (isFirst)
        {
            StartCoroutine(IdleFarm());
        }
        

    }

    public void GetFirst()
    {
        int money = PlayerPrefs.GetInt("money");
        money += 10;
        PlayerPrefs.SetInt("money", money);
        isFirst = true;
        PlayerPrefs.SetInt("isFirst", isFirst ? 1 : 0);
    }
    private void Update()
    {
        if (total_Money >= 10 && !isFirst)
        {
            firstAch.interactable = true;
        }
        else
        {

            firstAch.interactable = false;
        }
    }


    public void Tomenu()
    {
        SceneManager.LoadScene(0);
    }
    IEnumerator IdleFarm()
    {
        yield return new WaitForSeconds(1);
        money++;
        Debug.Log(money);
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarm());
    }


}
