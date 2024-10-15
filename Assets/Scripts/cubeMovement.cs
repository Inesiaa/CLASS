using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    public float rotationSpeed = 10f;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(1f * Time.deltaTime * rotationSpeed, 1f * Time.deltaTime * rotationSpeed, 1f * Time.deltaTime * rotationSpeed)/* * Time.deltaTime * rotationSpeed*/;
    }
}
