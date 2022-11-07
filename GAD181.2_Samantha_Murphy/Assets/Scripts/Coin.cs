using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField]
    public CoinCounter coinObj;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            coinObj.numberOfCoins++;
            coinObj.coinsText.text = coinObj.numberOfCoins.ToString();
        }
    }

  //  public void AddCoin()
   // {
  //      coinObj.numberOfCoins++;
  //      coinObj.coinsText.text = coinObj.numberOfCoins.ToString();
  //  }
  
}
