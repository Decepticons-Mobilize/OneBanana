using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed = 5.0f;
    [SerializeField] public float turnSpeed;
    [SerializeField] public float horizontalInput;
    [SerializeField] public float forwardInput;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
