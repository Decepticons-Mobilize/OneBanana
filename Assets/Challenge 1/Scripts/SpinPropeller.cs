using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public float rotateSpeed = 200f;
    public GameObject Propeller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Propeller.transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }
}
