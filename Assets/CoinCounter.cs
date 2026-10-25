
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int coins = 0;
    public TextMeshProUGUI coinText;

    public void AddCoin()
    {
        coins++;
        coinText.text = "Coins: " + coins;
    }
}
