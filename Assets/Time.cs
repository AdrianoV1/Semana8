using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI coinText;
    private int coinsCollected = 0;


    private float currentTime = 0f;

    private void Start()
    {
        timeText.text = "Tiempo: 0s";
        UpdateCoinText();
    }

    private void Update()
    {
        {
            currentTime += Time.deltaTime;


            timeText.text = "Tiempo: " + currentTime.ToString("F1") + "s";

        }
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        coinText.text = "Monedas: " + coinsCollected;
    }
}

