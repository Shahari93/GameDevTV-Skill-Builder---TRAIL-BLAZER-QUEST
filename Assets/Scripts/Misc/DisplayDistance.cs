using UnityEngine;
using TMPro;

public class DisplayDistance : MonoBehaviour
{
    CheckDistanceFromStart checkDistance;
    TMP_Text distanceText;

    private void Start()
    {
        checkDistance = FindObjectOfType<CheckDistanceFromStart>();
        distanceText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        var distInInt = Mathf.Round(checkDistance.DistTraveld);
        distanceText.text = $"Score: {distInInt.ToString()}";
    }
}