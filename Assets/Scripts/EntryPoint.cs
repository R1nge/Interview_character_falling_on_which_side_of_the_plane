using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [Header("Character")]
    [SerializeField] private Transform character;
    [SerializeField] private CharacterPhysics characterPhysics;
    
    [Header("Plane")]
    [SerializeField] private Transform plane;
    [SerializeField] private PlaneRotator planeRotator;

    private void Awake()
    {
       Init(); 
    }

    private void Init()
    {
        planeRotator.Rotate();
    }
}