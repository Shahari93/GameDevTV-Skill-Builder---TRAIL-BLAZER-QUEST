using UnityEngine;
using TMPro;

public class DisplayDistance : MonoBehaviour
{
    [SerializeField] CheckDistanceFromStart checkDistance;

    [SerializeField] TMP_Text distanceText;

    private void Update()
    {
        DisplayScore();
    }

    private void DisplayScore()
    {
        DisplayText(distanceText, "Score: ");
    }

    private void DisplayText(TMP_Text txt, string scoreTxt)
    {
        var distInInt = Mathf.Round(checkDistance.DistTraveld);
        txt.text = $"{scoreTxt} {distInInt.ToString()}";
    }
}