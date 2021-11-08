using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudPooler : MonoBehaviour
{
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
        pooledObject = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.transform.SetParent(this.transform);
            obj.transform.position = new Vector3(Random.Range(85.266f, 100f), 0, 0);
            obj.SetActive(false);
            pooledObject.Add(obj);
        }
    }
}
