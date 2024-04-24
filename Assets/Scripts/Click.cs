using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Click : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private int _score;
    [SerializeField] private int maxValue;
    [SerializeField] private int currentLevel;


    [Header("Properties")]
    [SerializeField] private GameObject gameCanvas;
    [SerializeField] private TextMeshProUGUI currentClicks;
    [SerializeField] private Image mask;

    public static readonly UnityEvent<int> AddScore = new();

    private void Start()
    {
        _score = 0;
    }

    private void RefreshFill()
    {
        float fillAmount = (float)_score / (float)maxValue;
        mask.fillAmount = fillAmount;
    }

    public void OnClick()
    {
        if (_score < maxValue)
        {
            Balance.AddCoin();
            _score++;
        }
        currentClicks.text = $"{_score} / {maxValue}";
        RefreshFill();
        if (_score >= maxValue)
        {
            AddScore.Invoke(_score);
        }
    }
}