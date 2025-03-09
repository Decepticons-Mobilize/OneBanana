using UnityEngine;

public class SwitchingCamera : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject secondCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        secondCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainCamera.SetActive(false);
            secondCamera.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            secondCamera.SetActive(false);
            mainCamera.SetActive(true);
            
        }
    }
}
