using System.Collections.Generic;
using UnityEngine;

public class CloudPooler : MonoBehaviour
{
    [SerializeField] GameObject player;

    public static CloudPooler sharedInstance;

    public List<GameObject> pooledObject;
    public GameObject objectToPool;
    public int amountToPool;

    private void Awake()
    {
        sharedInstance = this;
    }

    private void Start()
    {
        SetUpObjectPool();
    }

    private void SetUpObjectPool()
    {
        pooledObject = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.transform.SetParent(this.transform);
            obj.transform.position = new Vector3(Random.Range(5f, objectToPool.transform.position.x), objectToPool.transform.position.y, Random.Range(10f, objectToPool.transform.position.x));
            obj.SetActive(true);
            pooledObject.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObject.Count; i++)
        {
            if (!pooledObject[i].activeInHierarchy)
            {
                return pooledObject[i];
            }
        }
        return null;
    }

    public void CreateNewCloud()
    {
        GameObject cloud = CloudPooler.sharedInstance.GetPooledObject();
        if (cloud != null)
        {
            cloud.transform.position = new Vector3(Random.Range(5f, player.transform.position.x + 7f), objectToPool.transform.position.y, Random.Range(10f, objectToPool.transform.position.x));
            cloud.SetActive(true);
        }
    }
}