using UnityEngine;

public class PlaneRotator : MonoBehaviour
{
    public void Rotate()
    {
        var randomX = Random.Range(-1f, 1f);
        var randomY = Random.Range(-1f, 1f);
        var randomZ = Random.Range(-1f, 1f);
        var randomAngle = Random.Range(-360, 360);
        transform.RotateAround(transform.position, new Vector3(randomX, randomY,randomZ), randomAngle);
    }
}