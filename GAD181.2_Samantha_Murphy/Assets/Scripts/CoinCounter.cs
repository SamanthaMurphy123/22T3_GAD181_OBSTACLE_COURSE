using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public int numberOfCoins;
    public TextMeshProUGUI coinsText;

    // Start is called before the first frame update
    void Start()
    {
        numberOfCoins = 0;
        coinsText.text = numberOfCoins.ToString();
    }

    
}
