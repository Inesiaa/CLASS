using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Door"))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
