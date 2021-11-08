using UnityEngine;

public class CloudCollision : MonoBehaviour
{
    private const string triggerTag = "CloudTrigger";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggerTag))
        {
            gameObject.SetActive(false);
            CloudPooler.sharedInstance.CreateNewCloud();
        }
    }
}
