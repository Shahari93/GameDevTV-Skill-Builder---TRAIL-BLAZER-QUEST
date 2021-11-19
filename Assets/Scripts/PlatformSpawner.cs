using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] List<GameObject> spawnablePlatforms;
    int lastPlat;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnPlatforms), 5, 2);
        lastPlat = spawnablePlatforms.Count - 1;
    }

    private void SpawnPlatforms()
    {
        GameObject newPlatGO = Instantiate(ReturnRandomPlatform(), ReturnRandomPlatformPosition(), Quaternion.identity);
        spawnablePlatforms.Add(newPlatGO);
        int newIndexForPlat = spawnablePlatforms.Count - 1;
        lastPlat = newIndexForPlat;
    }

    private GameObject ReturnRandomPlatform()
    {
        int randPlatIndex = Random.Range(0, spawnablePlatforms.Count - 1);
        GameObject randPlat = spawnablePlatforms[randPlatIndex];
        return randPlat;
    }

    private Vector3 ReturnRandomPlatformPosition()
    {
        Vector3 newPos = new Vector3(spawnablePlatforms[lastPlat].transform.position.x + 7,
        Random.Range(spawnablePlatforms[lastPlat].transform.position.y - 2.5f, spawnablePlatforms[lastPlat].transform.position.y + 2.5f),
        spawnablePlatforms[lastPlat].transform.position.z);

        return newPos;
    }
}