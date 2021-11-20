using UnityEngine;
using TMPro;

public class DispalyScore : MonoBehaviour
{
    CollectCoins collectCoins;
    TMP_Text coinsAmountTxt;

    private void Start()
    {
        collectCoins = FindObjectOfType<CollectCoins>();
        coinsAmountTxt = GetComponent<TMP_Text>();
    }


    // Update is called once per frame
    void Update()
    {
        coinsAmountTxt.text = $"Coins: {collectCoins.CoinsAmount.ToString()}";
    }
}