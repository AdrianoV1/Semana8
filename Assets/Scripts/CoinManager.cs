using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    private int coinsCollected = 0;

    private void Start()
    {
        UpdateCoinText();
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
