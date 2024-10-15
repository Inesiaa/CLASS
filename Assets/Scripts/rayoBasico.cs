using UnityEngine;

public class rayoBasico : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            Debug.Log("Golpeó:" + hit.collider.name);
        }
    }
}
