using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public float degreeOfRotation = -85f;

    public GameObject wall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.Rotate(0, degreeOfRotation, 0);
        this.GetComponent<Collider>().enabled = false;

    }
}
