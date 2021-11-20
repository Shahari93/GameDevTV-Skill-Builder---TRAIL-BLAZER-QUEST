using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistanceFromStart : MonoBehaviour
{
    [SerializeField] Transform startPos;
    Vector3 firstPos;
    private float distTraveld;
    public float DistTraveld
    {
        get
        {
            return distTraveld;
        }
    }

    private void Start()
    {
        firstPos = startPos.position;
    }

    private void Update()
    {
        distTraveld += Vector3.Distance(transform.position, firstPos);
        firstPos = transform.position;
    }
}