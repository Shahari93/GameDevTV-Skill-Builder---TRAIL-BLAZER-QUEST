using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] float cloudMoveSpeed;
    Vector3 cloupPos;

    private void Start()
    {
        cloudMoveSpeed = Random.Range(2, 9);
    }

    void Update()
    {
        //.position -= new Vector3(cloudMoveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        transform.position -= NewCloudPos();
    }

    private Vector3 NewCloudPos()
    {
        cloupPos = new Vector3(cloudMoveSpeed * Time.deltaTime, 0, 0);
        return cloupPos;
    }
}