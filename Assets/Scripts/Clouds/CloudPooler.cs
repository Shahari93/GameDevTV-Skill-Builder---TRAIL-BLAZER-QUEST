using System.Collections.Generic;
using UnityEngine;

public class CloudPooler : MonoBehaviour
{
    public static CloudPooler sharedInstance;

    public List<GameObject> pooledObject;
    public GameObject objectToPool;
    public int amountToPool;

    private Camera mainCam;

    private void Awake()
    {
        sharedInstance = this;
    }

    private void Start()
    {
        mainCam = Camera.main;
        SetUpObjectPool();
    }

    private void SetUpObjectPool()
    {
        pooledObject = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = Instantiate(objectToPool);
            obj.transform.SetParent(this.transform);
            obj.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
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
            //cloud.transform.position = turret.transform.position;
            cloud.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            cloud.SetActive(true);
        }
    }

}
