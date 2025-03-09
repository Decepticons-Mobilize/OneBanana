using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 100;
    private float lowerBound = -10;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
