using UnityEngine;

public class CharacterPhysics : MonoBehaviour
{
    [SerializeField] private float gravity = 9.81f;

    private void Update()
    {
        transform.position += Vector3.down * (gravity * Time.deltaTime);
    }
}