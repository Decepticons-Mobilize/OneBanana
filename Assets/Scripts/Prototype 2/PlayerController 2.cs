using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float horizontalInput;
    public float speedPlayer = 10.0f;
    public float xBoundary = 24.0f;

    public GameObject projectilePrefab;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.x < -xBoundary)
        {
            transform.position = new Vector3(-xBoundary, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xBoundary)
        {
            transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right *  horizontalInput * Time.deltaTime * speedPlayer);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
