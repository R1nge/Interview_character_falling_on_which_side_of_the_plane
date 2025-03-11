using UnityEngine;

public class RelativePositionDetector : MonoBehaviour
{
    [SerializeField] private Transform character;
    [SerializeField] private Transform[] corners;

    private void Update()
    {
        Detect();
    }

    private void Detect()
    {
        if (IsAboveThePlane())
        {
            Debug.Log("Character is above the plane");
        }
        else
        {
            Debug.Log("Character is below the plane");
        }
    }

    private bool IsAboveThePlane()
    {
        foreach (var corner in corners)
        {
            if (GetSign(corner.position.y, character.position.y) > 0)
            {
                return true;
            }
        }
        
        return false;
    }

    private float GetSign(float corner, float character)
    {
        var signDistance = character - corner;
        return signDistance;
    }
}