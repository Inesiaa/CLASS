using UnityEngine;

public class scriptDePrueba : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        
        
        translation *= Time.deltaTime; // Make it move 10 meters per second instead of 10 meters per frame...
        rotation *= Time.deltaTime;
        
        transform.Translate(0, 0, translation); // Move translation along the object's z-axis
        
        transform.Rotate(0, rotation, 0); //Rotate around our y-axis


        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.grey;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
