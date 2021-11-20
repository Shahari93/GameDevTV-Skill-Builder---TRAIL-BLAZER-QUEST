using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
    [SerializeField] GameObject player;

    private void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter() 
    {
        SceneManager.LoadScene(0);
    }
}