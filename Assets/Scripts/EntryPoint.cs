using UnityEngine;
using Random = UnityEngine.Random;

public class EntryPoint : MonoBehaviour
{
    [Header("Start values")]
    [SerializeField] private Transform characterStartPosition;
    
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
        character.transform.position = characterStartPosition.position;
        var randomValue = Random.Range(-3, 3);
        character.transform.position += new Vector3(randomValue, characterStartPosition.position.y, randomValue);
        planeRotator.Rotate();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Init();
        } 
    }
}