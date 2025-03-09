using UnityEngine;

public class SecondCameraFollow : MonoBehaviour
{
    public GameObject secondcameraPlayer;
    private Vector3 offset1 = new Vector3(0, 2, -1);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = secondcameraPlayer.transform.position + offset1;
    }
}
