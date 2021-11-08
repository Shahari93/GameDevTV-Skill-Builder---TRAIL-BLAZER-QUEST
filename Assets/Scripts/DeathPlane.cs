using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
    private void OnTriggerEnter() 
    {
        SceneManager.LoadScene(0);
    }
}