using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private int coinsAmount = 0;
    public int CoinsAmount
    {
        get
        {
            return coinsAmount;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinsAmount++;
            Destroy(other.gameObject);
        }
    }
}
