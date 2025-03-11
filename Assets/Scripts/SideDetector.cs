using UnityEngine;

public class SideDetector : MonoBehaviour
{
    [SerializeField] private Transform[] corners;
    [SerializeField] private Transform character;

    private void Update()
    {
       Detect(); 
    }

    private void Detect()
    {
        if (IsOnTop())
        {
            Debug.LogWarning("Character is at the top of the plane");
        }
        else
        {
            Debug.LogWarning("Character is at the bottom of the plane");
        }
    }

    private bool IsOnTop()
    {
        foreach (var corner in corners)
        {
            var up = corner.TransformDirection(Vector3.up);
            var other = Vector3.Normalize(character.position - up);
            if (Vector3.Dot(up, other) > 0)
            {
                return true;
            }
        }

        return false;
    }
}