using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainGame : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneyText;
    public int totalMoney;


    void Start()
    {
        bool isFirst = PlayerPrefs.GetInt("isFirst") == 1 ? true : false;
        money = PlayerPrefs.GetInt("money");
        totalMoney = PlayerPrefs.GetInt("totalMoney", totalMoney);



        if (isFirst)
        {
            StartCoroutine(IdleFarm());
        }
    }
    public void OnClick()
    {
        money++;
        totalMoney++;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("totalMoney", totalMoney);
    }


    public void ToAchivments()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
    IEnumerator IdleFarm()
    {
        yield return new WaitForSeconds(1);
        money++;
        Debug.Log(money);
        PlayerPrefs.SetInt("money", money);
        StartCoroutine(IdleFarm());
    }

    public void OnclickOnRestart()
    {
        SceneManager.LoadScene(0);
        PlayerPrefs.DeleteAll();
    }


}
