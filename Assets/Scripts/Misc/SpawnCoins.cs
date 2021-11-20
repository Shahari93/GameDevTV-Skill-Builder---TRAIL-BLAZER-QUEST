using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] GameObject coins;
    [SerializeField] Transform player;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnNewCoins), 2, 2);
    }

    private void SpawnNewCoins()
    {
        GameObject newCoin = Instantiate(coins, RandomSpawnPoint(), Quaternion.identity);
    }

    private Vector3 RandomSpawnPoint()
    {
        Vector3 coinSpawnPos = new Vector3(player.position.x + 6, Random.Range(player.position.y - 2.5f, player.position.y + 2.5f), player.position.z);
        return coinSpawnPos;
    }
}